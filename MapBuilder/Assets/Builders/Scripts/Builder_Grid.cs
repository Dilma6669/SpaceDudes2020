using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
#if UNITY_EDITOR
    using UnityEditor;
#endif

public class Builder_Grid : MonoBehaviour
{

    // If future Dylan forgets how to put panels into location nodes, you need to create a empty gameobject inside the location node and then copy the panel into that empty gameobject
    // that will place the panel into the correct location node and then remove the empty gameobject and reset the transform position values.

    public GameObject GridContainer;

    public List<List<List<GameObject>>> yObjects;

    public List<int[]> dataArrayList;

    public TextAsset TextFile;

    void Start()
    {
        PutGridIntoLists();

        GetGridInteriorData();

        SaveDataArrayIntoDoc();

        print("FINISHED!!!");

    }

    //////////////////////////////////////////////

    private void PutGridIntoLists()
    {
        yObjects = new List<List<List<GameObject>>>();
        foreach (Transform yChild in GridContainer.transform)
        {
            List<List<GameObject>> zObjects = new List<List<GameObject>>();
            foreach (Transform zChild in yChild.gameObject.transform)
            {
                List<GameObject> xObjects = new List<GameObject>();
                foreach (Transform xChild in zChild.gameObject.transform)
                {
                    xObjects.Add(xChild.gameObject);
                }
                zObjects.Add(xObjects);
            }
            yObjects.Add(zObjects);
        }
    }

    //////////////////////////////////////////////

    private void GetGridInteriorData()
    {
        dataArrayList = new List<int[]>();

        foreach (List<List<GameObject>> yChild in yObjects)
        {
            foreach (List<GameObject> zChild in yChild)
            {
                foreach (GameObject xChild in zChild)
                {
                    CubeStruct cubeData = GetCubeData(xChild);

                    int[] dataArray = ConvertCubeDataIntoIntArray(cubeData);

                    dataArrayList.Add(dataArray);
                }
            }
        }
    }

    //////////////////////////////////////////////

    private CubeStruct GetCubeData(GameObject xChild)
    {
        // set a empty data shell
        CubeStruct data = new CubeStruct()
        {
            styleType = CubeObjectStyles.Default,
            health = 0,
            objectType = CubeObjectTypes.Empty,
            rotation = Vector3.zero
        };

        GameObject cubeObject = null;

        int activeChildcount = 0;
        foreach (Transform child in xChild.transform)
        {
            if (child.gameObject.activeSelf)
            {
                cubeObject = child.gameObject;
                activeChildcount += 1;
                Debug.Log("Adding cubeObject.name >> " + cubeObject.name);
            }
        }


        if (activeChildcount == 1)
        {
            if (!CheckAngle(cubeObject.transform.rotation.eulerAngles))
            {
                Debug.Log("BAD ANGLE at location >> " + xChild.transform.position);
            }

            return data = new CubeStruct()
            {
                styleType = cubeObject.GetComponent<CubeObjectScript>().cubeStyle,
                health = 100,
                objectType = cubeObject.GetComponent<CubeObjectScript>().cubeType,
                rotation = cubeObject.transform.rotation.eulerAngles
            };
        }
        else if (activeChildcount == 0 || activeChildcount > 1)
        {
            if (activeChildcount > 1)
            {
                Debug.Log("TOOOOOOO many child active at loc: " + xChild.transform.position);
            }
        }
        return data;
    }

    //////////////////////////////////////////////

    private int[] ConvertCubeDataIntoIntArray(CubeStruct cubeData)
    {
        int[] dataArray = new int[6];

        dataArray[0] = (int)cubeData.styleType;
        dataArray[1] = (int)cubeData.health;
        dataArray[2] = (int)cubeData.objectType;
        dataArray[3] = (int)cubeData.rotation.x;
        dataArray[4] = (int)cubeData.rotation.y;
        dataArray[5] = (int)cubeData.rotation.z;

        return dataArray;

    }

    //////////////////////////////////////////////

    private bool CheckAngle(Vector3 rotation)
    {
        int[] angleChecks = new int[]
        {
            0,
            45,
            -45,
            90,
            -90,
            180,
            -180,
            270,
            -270,
            360,
            -360,
            315,
            -315
        };

        bool angleXFound = false;
        bool angleYFound = false;
        bool angleZFound = false;


        foreach (int angle in angleChecks)
        {
            if ((int)rotation.x == angle)
            {
                angleXFound = true;
            }
            if ((int)rotation.y == angle)
            {
                angleYFound = true;
            }
            if ((int)rotation.z == angle)
            {
                angleZFound = true;
            }
        }

        if (!angleXFound)
        {
            Debug.Log("Got a bad X angle here!! " + (int)rotation.x);
            return false;
        }
        if (!angleYFound)
        {
            Debug.Log("Got a bad Y angle here!! " + (int)rotation.y);
            return false;
        }
        if (!angleZFound)
        {
            Debug.Log("Got a bad Z angle here!! " + (int)rotation.z);
            return false;
        }

        return true;
    }

    //////////////////////////////////////////////

    private void SaveDataArrayIntoDoc()
    {
        #if UNITY_EDITOR
            string path = AssetDatabase.GetAssetPath(TextFile);

            File.WriteAllText(path, "");

            if (File.Exists(path))
            {
            int count = 1;
            foreach (int[] dataArray in dataArrayList)
            {
                if (count != dataArrayList.Count)
                {
                    File.AppendAllText(path, dataArray[0] + " " + dataArray[1] + " " + dataArray[2] + " " + dataArray[3] + " " + dataArray[4] + " " + dataArray[5] + ",\n");
                }
                else
                {
                    File.AppendAllText(path, dataArray[0] + " " + dataArray[1] + " " + dataArray[2] + " " + dataArray[3] + " " + dataArray[4] + " " + dataArray[5]);
                }
                count++;
            }
            }
        #endif
    }

    //////////////////////////////////////////////

}