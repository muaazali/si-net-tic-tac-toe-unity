using System.Collections;
using System.Collections.Generic;
using SiNet;
using SiNet.Client;
using UnityEngine;

public class ClientConnection : MonoBehaviour
{
    Client client;

    void Start()
    {
        client = new Client(new ClientConnectionSettings(
            ip: "127.0.0.1",
            port: 5000
        ));
    }

    void OnDestroy()
    {
        client.DisconnectFromServer();
    }

    public void SendMessageToServer()
    {
        Debug.Log("Sending msg");
        client.SendMessageToServer(MessageUtility.CreateMessage(
            "CUSTOM_MESSAGE",
            "Hello from client!"
        ));
    }
}
