using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using MessagePack;
using RakNet;
using UnityEngine;
using RakNet = RakNet.RakNet;

namespace RakNetServer
{
    public class ServerEntry
    {
        private bool _isServerRunning;

        public delegate void AddReceivedDataCallback(string text);
        public delegate void MessageBoxCallback(string text);
        public MessageBoxCallback MessageBox;
        public AddReceivedDataCallback AddReceivedData;
        public AddReceivedDataCallback AddSenderInfo;
        RakPeerInterface server;
        Packet p;
        byte packetIdentifier;
        Thread lis;
        public ushort Port = 1234;
        public string ServerIP { get; private set; }
        public string GUID { get; private set; }

        public static List<byte[]> BinaryData = new List<byte[]>();
        public void StartServer(ushort port, string password, bool occasionalPing = true, ushort maxConnection = 4, uint unrealiableTimeout = 1000)
        {
            server = RakPeerInterface.GetInstance();
            server.SetIncomingPassword(password, password.Length);// "Rumpelstiltskin"
            server.SetTimeoutTime(30000, global::RakNet.RakNet.UNASSIGNED_SYSTEM_ADDRESS);
            p = new Packet();
            SystemAddress clientID = global::RakNet.RakNet.UNASSIGNED_SYSTEM_ADDRESS;
            SocketDescriptor socketDesc = new SocketDescriptor(port, "");
            StartupResult result = server.Startup(maxConnection, socketDesc, 1);
            server.SetMaximumIncomingConnections(maxConnection);
            if (result != StartupResult.RAKNET_STARTED)
                MessageBox("Server failed to start.  Terminating.");
            else
                MessageBox("Server start successfully");
            server.SetOccasionalPing(occasionalPing);
            server.SetUnreliableTimeout(unrealiableTimeout);
            StringBuilder ipsb = new StringBuilder();
            for (int i = 0; i < server.GetNumberOfAddresses(); i++)
            {
                SystemAddress sa = server.GetInternalID(global::RakNet.RakNet.UNASSIGNED_SYSTEM_ADDRESS, i);
                ipsb.Append(string.Format("{0}. {1}", i + 1, sa.ToString(false)));
            }
            ServerIP = ipsb.ToString();
            GUID = server.GetGuidFromSystemAddress(global::RakNet.RakNet.UNASSIGNED_SYSTEM_ADDRESS).ToString();
            lis = new Thread(Listening);
            lis.Start();

            _isServerRunning = true;
        }

        public void SendString(string content, PacketPriority priority = PacketPriority.MEDIUM_PRIORITY, PacketReliability reliability = PacketReliability.RELIABLE)
        {
            byte[] bs = Encoding.UTF8.GetBytes(content);
            RakString s = new RakString();
            s.AppendBytes(bs, (uint)bs.Length);
            server.Send(s.C_String(), (int)s.GetLength(), priority, reliability, '\0', global::RakNet.RakNet.UNASSIGNED_SYSTEM_ADDRESS, true);
        }
        private void Listening()
        {
            while (_isServerRunning)
            {
                Thread.Sleep(10);
                for (p = server.Receive(); p != null; server.DeallocatePacket(p), p = server.Receive())
                {
                    AddSenderInfo(string.Format("Time:{0} IP:{1} GUID:{2} Length:{3}", System.DateTime.Now.TimeOfDay, p.systemAddress.ToString(), p.guid, p.length));

                    packetIdentifier = GetPacketIdentifier(p);
                    switch ((DefaultMessageIDTypes)packetIdentifier)
                    {
                        case DefaultMessageIDTypes.ID_DISCONNECTION_NOTIFICATION:
                            MessageBox("ID_DISCONNECTION_NOTIFICATION");
                            break;
                        case DefaultMessageIDTypes.ID_ALREADY_CONNECTED:
                            MessageBox("ID_ALREADY_CONNECTED with guid " + p.guid);
                            break;
                        case DefaultMessageIDTypes.ID_INCOMPATIBLE_PROTOCOL_VERSION:
                            MessageBox("ID_INCOMPATIBLE_PROTOCOL_VERSION ");
                            break;
                        case DefaultMessageIDTypes.ID_REMOTE_DISCONNECTION_NOTIFICATION:
                            MessageBox("ID_REMOTE_DISCONNECTION_NOTIFICATION ");
                            break;
                        case DefaultMessageIDTypes.ID_REMOTE_CONNECTION_LOST: // Server telling the clients of another client disconnecting forcefully.  You can manually broadcast this in a peer to peer enviroment if you want.
                            MessageBox("ID_REMOTE_CONNECTION_LOST");
                            break;
                        case DefaultMessageIDTypes.ID_CONNECTION_BANNED: // Banned from this server
                            MessageBox("We are banned from this server.\n");
                            break;
                        case DefaultMessageIDTypes.ID_CONNECTION_ATTEMPT_FAILED:
                            MessageBox("Connection attempt failed ");
                            break;
                        case DefaultMessageIDTypes.ID_NO_FREE_INCOMING_CONNECTIONS:
                            MessageBox("Server is full ");
                            break;
                        case DefaultMessageIDTypes.ID_INVALID_PASSWORD:
                            MessageBox("ID_INVALID_PASSWORD\n");
                            break;
                        case DefaultMessageIDTypes.ID_CONNECTION_LOST:
                            // Couldn't deliver a reliable packet - i.e. the other system was abnormally
                            // terminated
                            MessageBox("ID_CONNECTION_LOST\n");
                            break;
                        case DefaultMessageIDTypes.ID_CONNECTION_REQUEST_ACCEPTED:
                            // This tells the client they have connected
                            MessageBox("ID_CONNECTION_REQUEST_ACCEPTED to %s " + p.systemAddress.ToString() + "with GUID " + p.guid.ToString());
                            MessageBox("My external address is:" + server.GetExternalID(p.systemAddress).ToString());
                            break;
                        case DefaultMessageIDTypes.ID_CONNECTED_PING:
                        case DefaultMessageIDTypes.ID_UNCONNECTED_PING:
                            MessageBox("Ping from " + p.systemAddress.ToString(true));
                            break;
                        default:
                            RakString s = new RakString();
                            s.AppendBytes(p.data, (uint)p.data.Length);
                            AddReceivedData(s.C_String());
                            BinaryData.Add(p.data);

                            //AddReceivedData("!!! send back bytes length: " + p.data.Length + ", client count: " + server.GetNumberOfAddresses());
                            //server.Send(p.data, p.data.Length, PacketPriority.MEDIUM_PRIORITY,
                            //    PacketReliability.RELIABLE_ORDERED,
                            //    (char) 0, p.systemAddress, false);
                            break;

                    }
                }
            }
        }

        private static byte GetPacketIdentifier(Packet p)
        {
            if (p == null)
                return 255;
            byte buf = p.data[0];
            if (buf == (char)DefaultMessageIDTypes.ID_TIMESTAMP)
            {
                return (byte)p.data[5];
            }
            else
                return buf;
        }
        public void Destroy()
        {
            if (lis != null)
            {
                lis.Abort();
                lis.Interrupt();
                lis = null;
            }
        }

        public void StopServer()
        {
            _isServerRunning = true;

            server.Shutdown(300);

            if (lis != null)
            {
                lis.Abort();
                lis.Interrupt();
                lis = null;
            }
        }

        public void TestSerialize()
        {
            var mc = new MyClass
            {
                Age = 99,
                FirstName = "hoge",
                LastName = "huga",
                Position = new Vector3Int(1, 3, 45),
            };

            // call Serialize/Deserialize, that's all.
            var bytes = MessagePackSerializer.Serialize(mc);
            var mc2 = MessagePackSerializer.Deserialize<MyClass>(bytes);

            // you can dump msgpack binary to human readable json.
            // In default, MeesagePack for C# reduce property name information.
            // [99,"hoge","huga"]
            var json = MessagePackSerializer.ToJson(bytes);

            Console.WriteLine(json);
        }
    }

    [MessagePackObject]
    public class MyClass
    {
        // Key is serialization index, it is important for versioning.
        [Key(0)]
        public int Age { get; set; }

        [Key(1)]
        public string FirstName { get; set; }

        [Key(2)]
        public string LastName { get; set; }

        // public members and does not serialize target, mark IgnoreMemberttribute
        [IgnoreMember]
        public string FullName { get { return FirstName + LastName; } }

        [Key(3)]
        public Vector3Int Position;
    }
}
