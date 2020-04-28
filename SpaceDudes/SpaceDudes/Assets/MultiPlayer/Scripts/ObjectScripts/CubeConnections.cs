﻿using UnityEngine;

public class CubeConnections : MonoBehaviour
{
    ////////////////////////////////////////////////

    private static CubeConnections _instance;

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

    // an attempt to make cubes as platforms FROM the neighbouring cubes with panels
    // the Full cube with SLOPE panel in it will be passed into this (differnt to function underneath) --dont think they are similar, they are not
    public static void SetCubeNeighbours(CubeLocationScript cubeScript)
    {
        cubeScript.SetNeighbourVects();

        // an attempt to make all sourounding cubes of Slope into movable cubes
        foreach (Vector3Int vect in cubeScript.NeighbourVects)
        {
            CubeLocationScript script = LocationManager.GetLocationScript_CLIENT(vect);

            if (script != null)
            {
                if (script.CubeMoveable && !script.CubeIsPanel)
                {
                    script.SetNeighbourVects();
                    script.CubePlatform = true;
                    //Debug.Log("fuck script.CubePlatform >> " + vect);
                }
            }
        }
        SetUpPanelInCube(cubeScript); // this call can only be made if slope panel inside full cube
    }

    // an attempt to make cubes as platforms FROM the neighbouring cubes with panels
    // the panel half cube will be passed into this
    public static void SetCubeHalfNeighbours(CubeLocationScript cubeHalfScript)
    {
        cubeHalfScript.SetHalfNeighbourVects(); // for the annoying slope issue

        // so this is essentially going through the proper neighbour cubes around the half panel cube
        foreach (Vector3Int vect in cubeHalfScript.NeighbourHalfVects)
        {
            // this will only return valid full cubes, only 2 will come thru, above and below
            CubeLocationScript cubeScript = LocationManager.GetLocationScript_CLIENT(vect);

            if (cubeScript != null)
            {
                if (cubeScript.CubeMoveable && !cubeScript.CubeIsPanel)
                {
                    cubeScript.CubePlatform = true;
                }
                cubeScript.SetNeighbourVects(); // for the annoying slope issue
            }                                   // NO CALL TO SETUPPANELINCUBE //IMPORTANT
        }

        SetUpPanelInCube(cubeHalfScript);
    }

    ////////////////////////////////////////////////


    // If ANY kind of wall/floor/object make neighbour cubes walkable
    public static void SetUpPanelInCube(CubeLocationScript neighbourHalfScript) {

        switch (neighbourHalfScript._panelScriptChild.name) 
		{
		case "Panel_Floor":
			SetUpFloorPanel (neighbourHalfScript);
			break;
		case "Panel_Wall":
			SetUpWallPanel (neighbourHalfScript);
			break;
		case "Panel_Angle": // angles put in half points
			SetUpFloorAnglePanel (neighbourHalfScript);
			break;
		default:
			Debug.Log ("fuck no ISSUE HERE");
			break;
		}
	}


    private static void SetHumanCubeRules(CubeLocationScript cubeScript, bool walkable, bool climable, bool jumpable)
    {
        cubeScript.IsHumanWalkable = walkable;
        cubeScript.IsHumanClimbable = climable;
        cubeScript.IsHumanJumpable = jumpable;
    }
    private static void SetAlienCubeRules(CubeLocationScript cubeScript, bool walkable, bool climable, bool jumpable)
    {
        cubeScript.IsAlienWalkable = walkable;
        cubeScript.IsAlienClimbable = climable;
        cubeScript.IsAlienJumpable = jumpable;
    }


    private static void SetUpFloorPanel(CubeLocationScript neighbourHalfScript) {

        PanelPieceScript panelScript = neighbourHalfScript._panelScriptChild;

        Vector3Int cubeHalfLoc = neighbourHalfScript.CubeID;

        Vector3Int leftVect = new Vector3Int (cubeHalfLoc.x, cubeHalfLoc.y - 1, cubeHalfLoc.z);
        CubeLocationScript cubeScriptLeft = LocationManager.GetLocationScript_CLIENT(leftVect); // underneath panel
        if (cubeScriptLeft != null && !cubeScriptLeft.CubeIsPanel) {
            panelScript.cubeScriptLeft = cubeScriptLeft;
			panelScript.cubeLeftVector = leftVect;
            cubeScriptLeft._platform_Panel_Cube = neighbourHalfScript;

            cubeScriptLeft._movementOffset_Left = Vector3Int.zero;

            SetHumanCubeRules(cubeScriptLeft, false, false, false);
            SetAlienCubeRules(cubeScriptLeft, true, true, true);
            cubeScriptLeft.IS_HUMAN_MOVABLE = false;
            cubeScriptLeft.IS_ALIEN_MOVABLE = true;
        }
        else
        {
            Debug.LogError("Got an issue here");
        }


        Vector3Int rightVect = new Vector3Int(cubeHalfLoc.x, cubeHalfLoc.y + 1, cubeHalfLoc.z);
        CubeLocationScript cubeScriptRight = LocationManager.GetLocationScript_CLIENT(rightVect); // Ontop of panel
        if (cubeScriptRight != null && !cubeScriptRight.CubeIsPanel)
        {
            panelScript.cubeScriptRight = cubeScriptRight;
            panelScript.cubeRightVector = rightVect;
            cubeScriptRight._platform_Panel_Cube = neighbourHalfScript;

            cubeScriptRight._movementOffset_Right = Vector3Int.zero;

            SetHumanCubeRules(cubeScriptRight, true, true, true);
            SetAlienCubeRules(cubeScriptRight, true, true, true);
            cubeScriptRight.IS_HUMAN_MOVABLE = true;
            cubeScriptRight.IS_ALIEN_MOVABLE = true;
        }
        else
        {
            Debug.LogError("Got an issue here");
        }
	}


	private static void SetUpWallPanel(CubeLocationScript neighbourHalfScript) {

        PanelPieceScript panelScript = neighbourHalfScript._panelScriptChild;

        Vector3Int cubeLoc = neighbourHalfScript.CubeID;

        Vector3Int rightVect = new Vector3Int(cubeLoc.x, cubeLoc.y, cubeLoc.z);
        Vector3Int leftVect = new Vector3Int(cubeLoc.x, cubeLoc.y, cubeLoc.z); // Underneath ( I think)


    int panelAngle = panelScript._panelYAxis;

        if (panelAngle == 0)
        {
            rightVect = new Vector3Int(cubeLoc.x + 1, cubeLoc.y, cubeLoc.z);
            leftVect = new Vector3Int(cubeLoc.x - 1, cubeLoc.y, cubeLoc.z); // Underneath ( I think)
        }
        else if (panelAngle == 90)
        {
            rightVect = new Vector3Int(cubeLoc.x, cubeLoc.y, cubeLoc.z + 1);
            leftVect = new Vector3Int(cubeLoc.x, cubeLoc.y, cubeLoc.z - 1); // Underneath ( I think)
        }
        else
        {
            Debug.LogError("fuck got an issue here");
        }

        CubeLocationScript cubeScriptLeft = LocationManager.GetLocationScript_CLIENT(leftVect);
        if (cubeScriptLeft != null && !cubeScriptLeft.CubeIsPanel)
        {
            panelScript.cubeScriptLeft = cubeScriptLeft;
            panelScript.cubeLeftVector = leftVect;
            cubeScriptLeft._platform_Panel_Cube = neighbourHalfScript;

            cubeScriptLeft._movementOffset_Left = Vector3Int.zero;

            if (panelScript._isLadder)
            {
                SetHumanCubeRules(cubeScriptLeft, true, true, true);
                cubeScriptLeft.IS_HUMAN_MOVABLE = true;
            }
            else
            {
                SetHumanCubeRules(cubeScriptLeft, false, false, false);
                cubeScriptLeft.IS_HUMAN_MOVABLE = false;
            }

            SetAlienCubeRules(cubeScriptLeft, true, true, true);
            cubeScriptLeft.IS_ALIEN_MOVABLE = true;
        }
        else
        {
           Debug.LogError("fuck got an issue here");
        }

        CubeLocationScript cubeScriptRight = LocationManager.GetLocationScript_CLIENT(rightVect);
        if (cubeScriptRight != null && !cubeScriptRight.CubeIsPanel)
        {
            panelScript.cubeScriptRight = cubeScriptRight;
            panelScript.cubeRightVector = rightVect;
            cubeScriptRight._platform_Panel_Cube = neighbourHalfScript;

            cubeScriptRight._movementOffset_Right = Vector3Int.zero;

            if (panelScript._isLadder)
            {
                SetHumanCubeRules(cubeScriptRight, true, true, true);
                cubeScriptRight.IS_HUMAN_MOVABLE = true;
            }
            else
            {
                SetHumanCubeRules(cubeScriptRight, false, false, false);
                cubeScriptRight.IS_HUMAN_MOVABLE = false;
            }

            SetAlienCubeRules(cubeScriptRight, true, true, true);
            cubeScriptRight.IS_ALIEN_MOVABLE = true;
        }
        else
        {
            Debug.LogError("fuck got an issue here");
        }
	}


    // this is a bit different, the actual MOVEABLE cube script gets passed in here coz slopes sit in the cube object not the half cube objects
    // THIS IS GOING TO CAUSE PROBLEMS IN FUTURE COZ THERES NO CHECKS IF THEY CAN MOVE ONTO SLOPE, ITS ALWAYS YES
    private static void SetUpFloorAnglePanel(CubeLocationScript cubeScript) // << hence the cubeScript NOT neighbourHalfScript
    {
        PanelPieceScript panelScript = cubeScript._panelScriptChild;

        Vector3Int cubeLoc = cubeScript.CubeID;

        Vector3Int rightVect = new Vector3Int(cubeLoc.x, cubeLoc.y, cubeLoc.z);
        Vector3Int leftVect = new Vector3Int(cubeLoc.x, cubeLoc.y, cubeLoc.z);

        int panelYaxis = panelScript._panelYAxis;

        int slopeAmount = 1;

        int xOffsetR = 0;
        int xOffsetL = 0;
        int zOffsetR = 0;
        int zOffsetL = 0;

        if (panelYaxis == 0)
        {
            xOffsetR = slopeAmount;
            xOffsetL = -slopeAmount;
            zOffsetR = 0;
            zOffsetL = 0;
        }
        else if (panelYaxis == 90)
        {
            xOffsetR = 0;
            xOffsetL = 0;
            zOffsetR = -slopeAmount;
            zOffsetL = slopeAmount;
        }
        else if (panelYaxis == 180)
        {
            xOffsetR = -slopeAmount;
            xOffsetL = slopeAmount;
            zOffsetR = 0;
            zOffsetL = 0;
        }
        else if (panelYaxis == 270)
        {
            xOffsetR = 0;
            xOffsetL = 0;
            zOffsetR = slopeAmount;
            zOffsetL = -slopeAmount;
        }
        else
        {
            Debug.Log("fuck got an issue here");
        }

        Vector3Int movementOffset_Left = new Vector3Int(xOffsetL, slopeAmount, zOffsetL); // Ontop
        Vector3Int movementOffset_Right = new Vector3Int(xOffsetR, -slopeAmount, zOffsetR);  // Underneath


        CubeLocationScript cubeScriptLeft = LocationManager.GetLocationScript_CLIENT(leftVect);
        if (cubeScriptLeft != null)
        {
            panelScript.cubeScriptLeft = cubeScriptLeft;
            panelScript.cubeLeftVector = leftVect;
            cubeScriptLeft._platform_Panel_Cube = cubeScript;

            cubeScriptLeft._movementOffset_Left = movementOffset_Left;

            SetHumanCubeRules(cubeScriptLeft, true, true, true);
            SetAlienCubeRules(cubeScriptLeft, true, true, true);
            cubeScriptLeft.IS_HUMAN_MOVABLE = true;
            cubeScriptLeft.IS_ALIEN_MOVABLE = true;
        }
        else
        {
            Debug.LogError("fuck got an issue here");
        }


        CubeLocationScript cubeScriptRight = LocationManager.GetLocationScript_CLIENT(rightVect);
        if (cubeScriptRight != null)
        {
            panelScript.cubeScriptRight = cubeScriptRight;
            panelScript.cubeRightVector = rightVect;
            cubeScriptRight._platform_Panel_Cube = cubeScript;

            cubeScriptRight._movementOffset_Right = movementOffset_Right;

            SetHumanCubeRules(cubeScriptRight, true, true, true);
            SetAlienCubeRules(cubeScriptRight, true, true, true);
            cubeScriptRight.IS_HUMAN_MOVABLE = true;
            cubeScriptRight.IS_ALIEN_MOVABLE = true;
        }
        else
        {
            Debug.LogError("fuck got an issue here");
        }
    }
}
