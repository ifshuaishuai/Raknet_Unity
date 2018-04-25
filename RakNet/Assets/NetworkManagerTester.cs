using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NetworkManagerTester : MonoBehaviour
{
    public Text _statusText;

    void Start()
    {
        NetworkManager.Instance.Init((bytes, length) =>
        {
            ReceiveData(bytes, length);
        }, type =>
        {
            Debug.Log("!!! server disconnct");
            AppendStatus("!!! server disconnct");
        });

        string ip = "192.168.31.194";
        int port = 1234;
        string password = "Rumpelstiltskin";

        NetworkManager.Instance.Connect(ip, port, password, () =>
        {
            Debug.Log("!!! connection success");
            AppendStatus("!!! connection success");
            // SendData();
        }, type =>
        {
            Debug.Log("!!! connection failed: " + type);
            AppendStatus("!!! connection failed: " + type);
        });
    }

    public void AppendStatus(string status)
    {
        _statusText.text = _statusText.text + "\n" + status;
    }

    private byte[] _bytes = new byte[5]{ 0x1, 0x2, 0x3, 0x4, 0x5, };

    void Update()
    {
        NetworkManager.Instance.Update();
    }

    private void SendData()
    {
        Debug.Log("!!! SendData");

        NetworkManager.Instance.Send(_bytes, _bytes.Length);
    }

    private void ReceiveData(byte[] bytes, int length)
    {
        Debug.Log("!!! ReceiveData length: " + length + ", bytes.Length: " + bytes.Length);
        bool allSame = true;
        for (int i = 0; i < length; ++i)
        {
            if (_bytes[i] != bytes[i])
            {
                allSame = false;
                break;
            }
        }

        Debug.Log("!!! allSame: " + allSame);
        NetworkManager.Instance.Disconnect();
    }
}
