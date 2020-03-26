using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using WebSocketSharp;
using WebSocketSharp.Server;
using SimpleJSON;

public class GameServer : MonoBehaviour
{
    WebSocketServer m_server;
    void Start()
    {
        m_server = new WebSocketServer (4649);
        m_server.AddWebSocketService<Echo> ("/Echo");
        m_server.Start ();
        // Console.ReadKey (true);
    }

    void OnApplicationQuit()
    {
        m_server.Stop ();
    }
}

public class Echo : WebSocketBehavior
{
    protected override void OnMessage (MessageEventArgs e)
    {
        // Debug.Log(e.Data);
        // Send ("");
        var json = JSON.Parse(e.Data);
        Debug.Log("Number of landmarks: " + json["landmarks"].Count);
    }
}
