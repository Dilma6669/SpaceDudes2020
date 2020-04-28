using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    ////////////////////////////////////////////////

    public UnitScript unitScript;

    private bool moveInProgress = false;

    private Vector3 _unitCurrPos;

    private List<Vector3Int> _nodes;

    private Vector3Int _currTargetCubeID;                 // current target ID

    private CubeLocationScript _currTargetScript;      // current target script
    public Vector3 _currTargetLoc;                     // vector of the moving cube Object
    private PanelPieceScript _currTargetPanelScript;

    public Vector3Int _finalTargetLoc;                     // vector of the moving cube Object
    private CubeLocationScript _finalTargetScript;      // final target script


    private int locCount;

    private int _unitsSpeed;

    private bool _newPathSet = false;
    private List<Vector3Int> _newPathNodes;

    private Animator[] _animators;

    private Transform unitContainerAnglesGLOBAL; // for rotations
    private Transform unitContainerTransformLOCAL; // for rotations
    private Transform unitContainerPIVOT; // for camera

    ////////////////////////////////////////////////
    ////////////////////////////////////////////////

    void Awake()
    {
        unitContainerAnglesGLOBAL = transform.FindDeepChild("UnitAngleContainer");
        unitContainerTransformLOCAL = transform.FindDeepChild("UnitContainer");
        unitContainerPIVOT = transform.FindDeepChild("Player_Pivot");
        _animators = GetComponentsInChildren<Animator>();
    }

    void Start()
    {
        unitScript = GetComponent<UnitScript>();

        _nodes = new List<Vector3Int>();
        _newPathNodes = new List<Vector3Int>();
    }


    // Use this for initialization
    void FixedUpdate()
    {

        if (moveInProgress)
        {
            StartMoving();
        }
    }

    ////////////////////////////////////////////////
    ////////////////////////////////////////////////

    private void StartMoving()
    {
        if (locCount < _nodes.Count)
        {
            _unitCurrPos = unitContainerTransformLOCAL.position;

            Vector3 currPos = _currTargetScript.transform.position;
            Vector3 moveOffset = _currTargetScript.GetCubeMovementOffset();

            _currTargetLoc = new Vector3(currPos.x + moveOffset.x, currPos.y + moveOffset.y, currPos.z + moveOffset.z);

            if (_unitCurrPos != _currTargetLoc)
            {
                UnitMoveTowardsTarget();
            }
            else
            {
                UnitReachedTarget();
            }
        }
    }

    ////////////////////////////////////////////////

    public void ChangeUnitsAngleAndCameraPivot()
    {
        PanelPieceScript panelScript = null;

        if(_currTargetPanelScript != null)
        {
            panelScript = _currTargetPanelScript;
        }
        else
        {
            panelScript = unitScript.CubeUnitIsOn._platform_Panel_Cube._panelScriptChild;
        }

        unitContainerTransformLOCAL.localEulerAngles = new Vector3(0, unitContainerTransformLOCAL.localEulerAngles.y, 0);

        unitContainerPIVOT.localEulerAngles = new Vector3(0, 0, 0);

        bool localState = CameraPivot.CameraStateIsLocal;

        switch (panelScript.name)
        {
            case "Panel_Floor":
                unitScript.UnitAngle = 0;
                unitContainerAnglesGLOBAL.localEulerAngles = new Vector3(0, 0, 0);
                break;
            case "Panel_Wall":
                unitScript.UnitAngle = 90;
                unitContainerAnglesGLOBAL.localEulerAngles = new Vector3(0, 0, 90);
                if (!localState)
                    unitContainerPIVOT.localEulerAngles = new Vector3(0, 0, -90);
                break;
            case "Panel_Angle": // angles put in half points
                unitScript.UnitAngle = 45;
                int panelYaxis = _currTargetPanelScript._panelYAxis;
                if (panelYaxis == 0)
                {
                    unitContainerAnglesGLOBAL.localEulerAngles = new Vector3(-45, 0, 0);
                    if (!localState)
                        unitContainerPIVOT.localEulerAngles = new Vector3(45, 0, 0);
                }
                else if (panelYaxis == 90)
                {
                    unitContainerAnglesGLOBAL.localEulerAngles = new Vector3(0, 0, 45);
                    if (!localState)
                        unitContainerPIVOT.localEulerAngles = new Vector3(0, 0, -45);
                }
                else if (panelYaxis == 180)
                {
                    unitContainerAnglesGLOBAL.localEulerAngles = new Vector3(45, 0, 0);
                    if (!localState)
                        unitContainerPIVOT.localEulerAngles = new Vector3(-45, 0, 0);
                }
                else if (panelYaxis == 270)
                {
                    unitContainerAnglesGLOBAL.localEulerAngles = new Vector3(0, 0, -45);
                    if (!localState)
                        unitContainerPIVOT.localEulerAngles = new Vector3(0, 0, 45);
                }
                break;
            default:
                Debug.LogError("FUCK got error here " + _currTargetPanelScript.name);
                break;
        }
    }


    private void UnitMoveTowardsTarget()
    {
        LocationManager.GetLocationScript_CLIENT(_currTargetScript.CubeID)._platform_Panel_Cube.CubeIsActivated();

        // Moving
        transform.position = Vector3.MoveTowards(transform.position, _currTargetLoc, Time.deltaTime * _unitsSpeed);

        // Rotation
        unitContainerTransformLOCAL.LookAt(_currTargetLoc, Vector3.up); // All the Y rotation we need

        if (MovementManager._gravityActivated)
        {
            //    unitContainerTransformLOCAL.localEulerAngles = new Vector3(0, unitContainerTransformLOCAL.localEulerAngles.y, 0);
            //    unitContainerAnglesGLOBAL.localEulerAngles = new Vector3(0, 0, 0);
        }
        else
        {
            ChangeUnitsAngleAndCameraPivot();
        }
    }

    ////////////////////////////////////////////////

    private void UnitReachedTarget()
    {
        //Debug.Log("UnitReachedTarget!");

        locCount += 1;

        transform.SetParent(_currTargetScript.transform);

        LocationManager.GetLocationScript_CLIENT(_currTargetScript.CubeID)._platform_Panel_Cube.CubeIsDEActivated();


        if (_newPathSet) // has a new location been clicked
        {
            SetNewpath();
        }
        else if (locCount < _nodes.Count) // move to next target
        {
            SetNextTarget();
        }
        else
        {
            FinishMoving();
        }
    }

    ////////////////////////////////////////////////

    private void SetNewpath()
    {
        ResetValues();
        _nodes = _newPathNodes;

        SetNextTarget();
    }

    ////////////////////////////////////////////////

    private void FinishMoving()
    {
        //Debug.Log("FINISHED MOVING!");

        AnimationManager.SetAnimatorBool(_animators, "Combat_Walk", false);
        moveInProgress = false;
        ResetValues();
    }

    ////////////////////////////////////////////////

    private void SetNextTarget()
    {
        _currTargetCubeID = _nodes[locCount];
        _currTargetScript = LocationManager.GetLocationScript_CLIENT(_currTargetCubeID);
        if (_currTargetScript._platform_Panel_Cube._panelScriptChild != null)
        {
            _currTargetPanelScript = _currTargetScript._platform_Panel_Cube._panelScriptChild;

            if (!LocationManager.SetUnitOnCube_CLIENT(GetComponent<UnitScript>(), _currTargetCubeID))
            {
                Debug.LogWarning("units movement interrupted >> recalculating");
                moveInProgress = false;
                ResetValues();
                if (MovementManager.BuildMovementPath(_finalTargetScript))
                {
                    MovementManager.MakeActiveUnitMove_CLIENT();
                }
            }
        }
    }

    ////////////////////////////////////////////////

    public void MoveUnit(List<Vector3Int> path)
    {
        AnimationManager.SetAnimatorBool(_animators, "Combat_Walk", true);

        _unitsSpeed = gameObject.transform.GetComponent<UnitScript>().UnitCombatStats[1]; // movement

        _finalTargetLoc = path[path.Count-1];
        _finalTargetScript = LocationManager.GetLocationScript_CLIENT(_finalTargetLoc);

        if (path.Count > 0)
        {
            if (moveInProgress)
            {
                foreach (Vector3Int nodeVect in _nodes)
                {
                    LocationManager.GetLocationScript_CLIENT(nodeVect)._platform_Panel_Cube._panelScriptChild.PanelIsDEActive();
                }
                _newPathNodes = path;
                _newPathSet = true;
            }
            else
            {
                ResetValues();
                _nodes = path;
                moveInProgress = true;
                foreach(Vector3Int nodeVect in _nodes)
                {
                    LocationManager.GetLocationScript_CLIENT(nodeVect)._platform_Panel_Cube._panelScriptChild.PanelIsActive();
                }
                SetNextTarget();
            }
        }
    }

    ////////////////////////////////////////////////

    private void ResetValues()
    {
        locCount = 0;
        //_dynamicTargetLocVect = Vector3Int.zero;
        //_staticTargetVect = new KeyValuePair<Vector3Int, Vector3Int>();
        //_staticFinalTargetVect = new KeyValuePair<Vector3Int, Vector3Int>();
        _newPathSet = false;
        foreach (Vector3Int nodeVect in _nodes)
        {
            CubeLocationScript script = LocationManager.GetLocationScript_CLIENT(nodeVect);
            script.DestroyPathFindingNode();
        }
        _nodes.Clear();
    }
}
