﻿using UnityEngine;

public class CubeBuilder : MonoBehaviour {

    ////////////////////////////////////////////////

    private static CubeBuilder _instance;

    ////////////////////////////////////////////////
    ////////////////////////////////////////////////

    void Awake()
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

    public static CubeLocationScript CreateCubeObject(Vector3Int localGridLoc, int[] cubeData, Transform parent)
    {
        GameObject cubeObject = WorldBuilder._nodeBuilder.CreateDefaultCube(localGridLoc, parent);
        CubeLocationScript cubeScript = cubeObject.GetComponent<CubeLocationScript>();

        if (cubeData[2] != 00)
        {
            PanelBuilder.CreatePanelForCube(cubeData, cubeScript);
        }
      
        SortOutCubeScriptShit(cubeScript);

        return cubeScript;
    }


    private static void SortOutCubeScriptShit(CubeLocationScript cubeScript)
    {
        // If cube is movable or not
        if (cubeScript.CubeMoveable)
        {
          LocationManager.SetCubeScriptToLocation_CLIENT(cubeScript.CubeID, cubeScript);
        }
        else
        {
            LocationManager.SetCubeScriptToHalfLocation_CLIENT(cubeScript.CubeID, cubeScript);
        }

        // for layering system
        //LayerManager.AddCubeToLayer(cubeScript);
    }

    ////////////////////////////////////////////////

}
