using UnityEngine;

public class PanelBuilder : MonoBehaviour
{
    ////////////////////////////////////////////////

    private static PanelBuilder _instance;

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

    public static void CreatePanelForCube(int[] cubeData, CubeLocationScript cubeScript)
    {
        GameObject panelObject = WorldBuilder._nodeBuilder.CreatePanelObject(cubeScript);
        PanelPieceScript panelScript = panelObject.GetComponent<PanelPieceScript>();

        int rotX = cubeData[3];
        int rotY = cubeData[4];
        int rotZ = cubeData[5];

        panelScript.cubeDataRotX = rotX;
        panelScript.cubeDataRotY = rotY;
        panelScript.cubeDataRotZ = rotZ;

        panelObject.transform.localPosition = new Vector3Int(0, 0, 0);
        panelObject.transform.localEulerAngles = new Vector3Int(rotX, rotY, rotZ);

        string name = "";

        if (rotX == 90 && rotY == 0 && rotZ == 0) // Floor
        {
            cubeScript.CubeIsSlope = false;
            //panelObject.transform.localScale = new Vector3Int(1, 1, 1);
            name = "Panel_Floor";
        }
        else if ((rotX == 0 && rotY == 90 && rotZ == 0) || (rotX == 0 && rotY == 0 && rotZ == 0)) // Wall
        {
            cubeScript.CubeIsSlope = false;
            //panelObject.transform.localScale = new Vector3Int(1, 1, 1);
            name = "Panel_Wall";
        }
        else
        {
            cubeScript.CubeIsSlope = true;
            panelObject.transform.localScale = new Vector3Int(20, 30, 1);
            name = "Panel_Angle";
        }

        panelObject.transform.tag = name;
        panelScript.name = name;

        panelScript._panelYAxis = rotY;

    }

}
