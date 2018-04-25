using System;
using System.Buffers;
using UnityEngine;
using UnityEngine.Assertions;
using RakNet;

using Object = UnityEngine.Object;

public class NetworkManager
{
    enum ADDRESS_FAMILIES_INT
    {
        /// <summary>
        /// Unspecified [value = 0].
        /// </summary>
        AF_UNSPEC = 0,
        /// <summary>
        /// Local to host (pipes, portals) [value = 1].
        /// </summary>
        AF_UNIX = 1,
        /// <summary>
        /// Internetwork: UDP, TCP, etc [value = 2].
        /// </summary>
        AF_INET = 2,
        /// <summary>
        /// Arpanet imp addresses [value = 3].
        /// </summary>
        AF_IMPLINK = 3,
        /// <summary>
        /// Pup protocols: e.g. BSP [value = 4].
        /// </summary>
        AF_PUP = 4,
        /// <summary>
        /// Mit CHAOS protocols [value = 5].
        /// </summary>
        AF_CHAOS = 5,
        /// <summary>
        /// XEROX NS protocols [value = 6].
        /// </summary>
        AF_NS = 6,
        /// <summary>
        /// IPX protocols: IPX, SPX, etc [value = 6].
        /// </summary>
        AF_IPX = 6,
        /// <summary>
        /// ISO protocols [value = 7].
        /// </summary>
        AF_ISO = 7,
        /// <summary>
        /// OSI is ISO [value = 7].
        /// </summary>
        AF_OSI = 7,
        /// <summary>
        /// european computer manufacturers [value = 8].
        /// </summary>
        AF_ECMA = 8,
        /// <summary>
        /// datakit protocols [value = 9].
        /// </summary>
        AF_DATAKIT = 9,
        /// <summary>
        /// CCITT protocols, X.25 etc [value = 10].
        /// </summary>
        AF_CCITT = 10,
        /// <summary>
        /// IBM SNA [value = 11].
        /// </summary>
        AF_SNA = 11,
        /// <summary>
        /// DECnet [value = 12].
        /// </summary>
        AF_DECnet = 12,
        /// <summary>
        /// Direct data link interface [value = 13].
        /// </summary>
        AF_DLI = 13,
        /// <summary>
        /// LAT [value = 14].
        /// </summary>
        AF_LAT = 14,
        /// <summary>
        /// NSC Hyperchannel [value = 15].
        /// </summary>
        AF_HYLINK = 15,
        /// <summary>
        /// AppleTalk [value = 16].
        /// </summary>
        AF_APPLETALK = 16,
        /// <summary>
        /// NetBios-style addresses [value = 17].
        /// </summary>
        AF_NETBIOS = 17,
        /// <summary>
        /// VoiceView [value = 18].
        /// </summary>
        AF_VOICEVIEW = 18,
        /// <summary>
        /// Protocols from Firefox [value = 19].
        /// </summary>
        AF_FIREFOX = 19,
        /// <summary>
        /// Somebody is using this! [value = 20].
        /// </summary>
        AF_UNKNOWN1 = 20,
        /// <summary>
        /// Banyan [value = 21].
        /// </summary>
        AF_BAN = 21,
        /// <summary>
        /// Native ATM Services [value = 22].
        /// </summary>
        AF_ATM = 22,
        /// <summary>
        /// Internetwork Version 6 [value = 23].
        /// </summary>
        AF_INET6 = 23,
        /// <summary>
        /// Microsoft Wolfpack [value = 24].
        /// </summary>
        AF_CLUSTER = 24,
        /// <summary>
        /// IEEE 1284.4 WG AF [value = 25].
        /// </summary>
        AF_12844 = 25,
        /// <summary>
        /// IrDA [value = 26].
        /// </summary>
        AF_IRDA = 26,
        /// <summary>
        /// Network Designers OSI &amp; gateway enabled protocols [value = 28].
        /// </summary>
        AF_NETDES = 28,
        /// <summary>
        /// [value = 29].
        /// </summary>
        AF_TCNPROCESS = 29,
        /// <summary>
        /// [value = 30].
        /// </summary>
        AF_TCNMESSAGE = 30,
        /// <summary>
        /// [value = 31].
        /// </summary>
        AF_ICLFXBM = 31
    }

    // 255 is reserved
    private const byte ID_Bytes = 254;

    private static NetworkManager _instance;

    public static NetworkManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new NetworkManager();
            }

            return _instance;
        }
    }

    private NetworkManager()
    {
        _client = RakPeerInterface.GetInstance();

        var socketDescriptor = new SocketDescriptor();
        socketDescriptor.socketFamily = (int)ADDRESS_FAMILIES_INT.AF_INET;

        var startupResult = _client.Startup(1, socketDescriptor, 1);
        if (startupResult != StartupResult.RAKNET_STARTED)
        {
            string message = "Couldn't start RakNet peer :" + startupResult;
            throw new Exception(message);
        }

        _client.SetOccasionalPing(true);
    }

    private RakPeerInterface _client;
    private RakNetGUID _rakNetGuid;

    private Action<byte[], int> _byteMessageAction;
    private Action<DefaultMessageIDTypes> _disconnectionAction;

    private Action _connectSuccessAction;
    private Action<DefaultMessageIDTypes> _connectFailedAction;

    public void Init(Action<byte[], int> byteMessageAction, Action<DefaultMessageIDTypes> disconnectionAction)
    {
        _byteMessageAction = byteMessageAction;
        _disconnectionAction = disconnectionAction;
    }

    public void Connect(string ip, int port, string password, Action connectSuccessAction, Action<DefaultMessageIDTypes> connectFailedAction)
    {
        _connectSuccessAction = connectSuccessAction;
        _connectFailedAction = connectFailedAction;

        ConnectionAttemptResult connectResult = _client.Connect(ip, Convert.ToUInt16(port), password, password != null ? password.Length : 0);
        if (connectResult != ConnectionAttemptResult.CONNECTION_ATTEMPT_STARTED)
        {
            string message = string.Format("Couldn't connect RakNet ip:{0} port:{1} result:{2}", ip, port, connectResult);
            throw new Exception(message);
        }
    }

    public void Update()
    {
        for (var p = _client.Receive(); p != null; _client.DeallocatePacket(p), p = _client.Receive())
        {
            var packetIdentifier = (DefaultMessageIDTypes)GetPacketIdentifier(p);
            Object.FindObjectOfType<NetworkManagerTester>().AppendStatus("packetIdentifier : " + packetIdentifier);

            switch (packetIdentifier)
            {
                // 连接成功
                case DefaultMessageIDTypes.ID_CONNECTION_REQUEST_ACCEPTED:
                    ProcessConnectSuccessProtocal();
                    break;

                // 已经连接
                case DefaultMessageIDTypes.ID_ALREADY_CONNECTED:
                // 被Ban
                case DefaultMessageIDTypes.ID_CONNECTION_BANNED: // Banned from this server
                // 连接失败
                case DefaultMessageIDTypes.ID_CONNECTION_ATTEMPT_FAILED:
                // 服务器已满
                case DefaultMessageIDTypes.ID_NO_FREE_INCOMING_CONNECTIONS:
                // 密码错误
                case DefaultMessageIDTypes.ID_INVALID_PASSWORD:
                    ProcessConnectFailedProtocal(packetIdentifier);
                    break;

                // =======================================
                // 断开连接
                case DefaultMessageIDTypes.ID_DISCONNECTION_NOTIFICATION:
                // 服务器断开连接
                case DefaultMessageIDTypes.ID_REMOTE_DISCONNECTION_NOTIFICATION:
                // 远程断开连接
                case DefaultMessageIDTypes.ID_REMOTE_CONNECTION_LOST: // Server telling the clients of another client disconnecting forcefully.  You can manually broadcast this in a peer to peer enviroment if you want.
                // 丢失连接
                case DefaultMessageIDTypes.ID_CONNECTION_LOST:
                // 协议不支持
                case DefaultMessageIDTypes.ID_INCOMPATIBLE_PROTOCOL_VERSION:
                    ProcessDisConnectionProtocal(packetIdentifier);
                    break;
                
                // ping消息
                case DefaultMessageIDTypes.ID_CONNECTED_PING:
                case DefaultMessageIDTypes.ID_UNCONNECTED_PING:
                    break;

                default:
                    ProcessMessage(p.data);
                    break;
            }
        }
    }

    // 连接丢失处理
    private void ProcessDisConnectionProtocal(DefaultMessageIDTypes packetIdentifier)
    {
        if (_disconnectionAction != null)
        {
            _disconnectionAction(packetIdentifier);
        }
    }

    public void Send(byte[] bytes, int sendLength)
    {
        Assert.IsNotNull(_rakNetGuid);
        Assert.AreEqual(ConnectionState.IS_CONNECTED, _client.GetConnectionState(_rakNetGuid));

        int bufferLength = sendLength + 1;
        
        // rent buffer
        byte[] buffer = ArrayPool<byte>.Shared.Rent(bufferLength);

        buffer[0] = ID_Bytes;
        Array.Copy(bytes, 0, buffer, 1, sendLength);

        _client.Send(buffer, bufferLength, PacketPriority.MEDIUM_PRIORITY, PacketReliability.RELIABLE_ORDERED, (char) 0,
            _rakNetGuid, false);

        // return buffer
        ArrayPool<byte>.Shared.Return(buffer);
    }

    public void Disconnect()
    {
        Assert.IsNotNull(_rakNetGuid);
        Assert.AreEqual(ConnectionState.IS_CONNECTED, _client.GetConnectionState(_rakNetGuid));

        _client.CloseConnection(_rakNetGuid, true);
        _client.Shutdown(300);

        _rakNetGuid = null;
    }

    // 收到消息
    private void ProcessMessage(byte[] data)
    {
        int id = data[0];

        if (id == ID_Bytes)
        {
           ProcessMessageBytes(data); 
        }
        else
        {
            // do noting
        }
    }

    private void ProcessMessageBytes(byte[] data)
    {
        if (_byteMessageAction != null)
        {
            int length = data.Length;

            // 左移一位，然后返回 length-1
            for (int i = 1; i < length; ++i)
            {
                data[i - 1] = data[i];
            }

            _byteMessageAction(data, length - 1);
        }
    }

    // 连接成功
    private void ProcessConnectSuccessProtocal()
    {
        _rakNetGuid = _client.GetGUIDFromIndex(0);

        if (_connectSuccessAction != null)
        {
            _connectSuccessAction();
        }

        _connectSuccessAction = null;
        _connectFailedAction = null;
    }

    // 连接失败
    private void ProcessConnectFailedProtocal(DefaultMessageIDTypes packetIdentifier)
    {
        if (_connectFailedAction != null)
        {
            _connectFailedAction(packetIdentifier);
        }

        _connectSuccessAction = null;
        _connectFailedAction = null;
    }

    private static byte GetPacketIdentifier(Packet p)
    {
        if (p == null)
        {
            return 255;
        }

        byte buf = p.data[0];
        if (buf == (char) DefaultMessageIDTypes.ID_TIMESTAMP)
        {
            return (byte) p.data[5];
        }
        else
        {
            return buf;
        }
    }
}
