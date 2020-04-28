using System.Collections.Generic;
using UnityEngine;

public class GridBuilder : MonoBehaviour
{
    ////////////////////////////////////////////////

    private static GridBuilder _instance;

    ////////////////////////////////////////////////

    public static bool _debugNodeSpheres = true;// debugging purposes

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

}
	

