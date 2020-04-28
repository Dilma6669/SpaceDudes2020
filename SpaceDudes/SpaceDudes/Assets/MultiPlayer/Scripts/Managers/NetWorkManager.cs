﻿using UnityEngine;
using UnityEngine.Networking;

public class NetWorkManager : NetworkManager
{
    ////////////////////////////////////////////////

    private static NetWorkManager _instance;

    ////////////////////////////////////////////////
    ////////////////////////////////////////////////

    void OnStartClient()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = this;
        }
    }


    ////////////////////////////////////////////////
    ////////////////////////////////////////////////


    //Detect when the Server starts and output the status
    public override void OnStartServer()
    {
        //Output that the Server has started
        Debug.Log("Server Started!");
    }

    //Detect when the Server stops
    public override void OnStopServer()
    {
        //Output that the Server has stopped
        Debug.Log("Server Stopped!");
    }



    // called on the SERVER when a client connects
    public override void OnServerConnect(NetworkConnection Conn)
    {
        Debug.Log("NETWORKMANAGER: Client Connect!! Con: " + Conn.hostId);

        SyncedVars _syncedVars = GameObject.Find("SyncedVars").GetComponent<SyncedVars>(); // needs to be here, function runs before awake
        if (_syncedVars == null) { Debug.LogError("We got a problem here"); }

        if (Conn.hostId == -1)
        {
            int globalSeed = Random.Range(0, 100);
            Random.InitState(globalSeed);
            _syncedVars.GlobalSeed = globalSeed;
        }

        _syncedVars.PlayerCount = 1;
    }
}
