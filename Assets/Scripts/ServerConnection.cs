using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SiNet.Server;

public class ServerConnection : MonoBehaviour
{
    void Start()
    {
        Server server = new Server(new ServerConnectionSettings(
            ip: "127.0.0.1",
            port: 5000
        ));
        server.OnClientConnected += OnClientConnected;
    }

    void OnClientConnected(ConnectedClientInfo clientInfo)
    {
        Debug.Log(string.Format("SERVER: Client connected: {0}", clientInfo.port));
    }
}
