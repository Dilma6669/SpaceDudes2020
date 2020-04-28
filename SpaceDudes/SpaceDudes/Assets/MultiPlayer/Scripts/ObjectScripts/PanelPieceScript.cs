using UnityEngine.EventSystems;
using UnityEngine;
using System.Collections;

public class PanelPieceScript : MonoBehaviour {

	Renderer _rend;

    static Camera mainCamera;

    public bool _panelActive = false;
	public bool transFlag = false;

	public int _panelYAxis = 0;

    public int cubeDataRotX = 0;
    public int cubeDataRotY = 0;
    public int cubeDataRotZ = 0;

    public Vector3Int cubeLeftVector;
	public Vector3Int cubeRightVector;

	public CubeLocationScript cubeScriptParent = null;
	public CubeLocationScript cubeScriptRight = null; // Ontop (Floor)
    public CubeLocationScript cubeScriptLeft = null; // Underneath (Floor)

    public CubeLocationScript _activeCubeScript = null;

	public bool _isLadder = false;

    public int _panelHitIndex = 0;

    public bool _movementPossible = false;

	public bool panelVisible = true;

	// Use this for initialization
	void Start () {
		_rend = GetComponent<Renderer> ();
        transform.gameObject.layer = LayerManager.LAYER_ENVIRONMENT;

        mainCamera = PlayerManager.CameraAgent.MainCamera;
    }

    public void PanelPieceChangeColor(string color)
    {
        Color origColour = _rend.material.color;
        Color tempColor = Color.white;

        switch (color)
        {
            case "Red":
                tempColor = Color.red;
                break;
            case "Black":
                tempColor = Color.black;
                break;
            case "White":
                tempColor = Color.white;
                break;
            case "Green":
                tempColor = Color.green;
                break;
            case "Pink":
                tempColor = Color.magenta;
                break;
            case "Yellow":
                tempColor = Color.yellow;
                break;
            default:
                break;
        }

        tempColor.a = origColour.a;
        _rend.material.color = tempColor;
    }


    public void PanelIsActive()
    {
        if (panelVisible)
         PanelPieceChangeColor("Green");
    }

    public void PanelIsDEActive()
    {
        if (panelVisible)
            PanelPieceChangeColor("White");
    }


    void OnMouseDown()
    {
        if (_movementPossible)
        {
            MovementManager.MakeActiveUnitMove_CLIENT(); // this just checks is a unit is currently selected and then does the moving shit
        }
    }


    void OnMouseOver()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        RaycastHit hitPoint;

        if(Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition), out hitPoint, 100.0F))
        {
            //Debug.Log("fuck hitPoint.gameObject " + hitPoint.transform.gameObject.name);

            if (!PlayerManager.CameraAgent.Camera_Pivot.CAMERA_MOVING)
            {
                _panelHitIndex = 0;

                int triIndex = hitPoint.triangleIndex;
                //Debug.Log("Hit Triangle index : " + hitPoint.triangleIndex);

                if (triIndex == 0 || triIndex == 1) // (if floor) To sit OnTop of panels
                {
                    _panelHitIndex = 1;

                    if (hitPoint.collider.tag == "Panel_Floor")
                        _activeCubeScript = cubeScriptLeft;

                    if (hitPoint.collider.tag == "Panel_Wall")
                    {
                        if (_panelYAxis == 0)
                            _activeCubeScript = cubeScriptRight;

                        if (_panelYAxis == 90)
                            _activeCubeScript = cubeScriptLeft;
                    }

                    if (hitPoint.collider.tag == "Panel_Angle")
                        _activeCubeScript = cubeScriptLeft;
                }
                else if (triIndex == 4 || triIndex == 5) // (if floor) To sit Underneath of panels
                {
                    _panelHitIndex = 2;

                    if (hitPoint.collider.tag == "Panel_Floor")
                        _activeCubeScript = cubeScriptRight;

                    if (hitPoint.collider.tag == "Panel_Wall")
                    {
                        if (_panelYAxis == 0)
                            _activeCubeScript = cubeScriptLeft;

                        if (_panelYAxis == 90)
                            _activeCubeScript = cubeScriptRight;
                    }

                    if (hitPoint.collider.tag == "Panel_Angle")
                        _activeCubeScript = cubeScriptRight;
                }
                else
                {
                    _activeCubeScript = null;
                    Debug.Log("Hit Triangle index NOT REGISTERED: " + triIndex);
                }



                if (MovementManager.BuildMovementPath(_activeCubeScript))
                {
                    PanelPieceChangeColor("Pink");
                    _movementPossible = true;
                }
                else
                {
                    PanelPieceChangeColor("White");
                    _movementPossible = false;
                }
            }
        }
    }

    private bool DetermineIfPanelIsLowerThanUnit() // ONLY FOR FLOOR PANELS
    {
        if (cubeScriptParent.MapNodeParent == null)
            return false;

        if (UnitsManager.ActiveUnit == null)
            return false;

        Vector3 mapNodePos = cubeScriptParent.MapNodeParent.transform.position;
        Vector3 unitPos = UnitsManager.ActiveUnit.transform.position;
        Vector3 panelPos = transform.position;

        float unitDist = Vector3.Distance(unitPos, mapNodePos);
        float panelDist = Vector3.Distance(panelPos, mapNodePos);

        return unitDist < panelDist;
    }

    //private bool PanelIsAllowedToGoInvisible()
    //{
    //    if (gameObject.name == "Panel_Floor")
    //    {

    //        bool panelBelowUnit = DetermineIfPanelIsLowerThanUnit();
    //        float camVertAngle = PlayerManager.CameraAgent.Camera_Pivot.CameraVerticalAngle;

    //        //Debug.Log("fuck panelBelowUnit " + panelBelowUnit);

    //        if (camVertAngle < 0)
    //        {
    //            //if (panelBelowUnit)
    //                return false;
    //        }
    //        //    else
    //        //    {
    //        //        if (!panelBelowUnit)
    //        //            return false;
    //        //    }
    //    }

    //    return true;
    //}


    public void GoHalfTransparent()
    {
        //if (!PanelIsAllowedToGoInvisible())
        //    return;

        if (_rend)
        {
            Color tempColor = _rend.material.color;
            tempColor.a = 0.1F;
            _rend.material.color = tempColor;

            panelVisible = false;
        }
        gameObject.layer = LayerManager.LAYER_IGNORE_RAYCAST;
        GetComponent<MeshRenderer>().enabled = true;
    }

    public void GoFullTransparent()
    {
        //if (!PanelIsAllowedToGoInvisible())
        //    return;

        if (_rend)
        {
            Color tempColor = _rend.material.color;
            tempColor.a = 0.1F;
            _rend.material.color = tempColor;

            panelVisible = false;
        }
        gameObject.layer = LayerManager.LAYER_IGNORE_RAYCAST;
        GetComponent<MeshRenderer>().enabled = false;
    }

    public void GoNotTransparent()
    {
        if (_rend)
        {
            Color tempColor = _rend.material.color;
            tempColor.a = 1F;
            _rend.material.color = tempColor;

            panelVisible = true;
        }
        gameObject.layer = LayerManager.LAYER_ENVIRONMENT;
        GetComponent<MeshRenderer>().enabled = true;
    }


    //private void OnTriggerEnter(Collider other)
    //{
    //   if(other.name == "PanelTrigger")
    //    {
    //        GoHalfTransparent();
    //    }
    //    if (other.name == "PanelTriggerCore")
    //    {
    //        GoFullTransparent();
    //    }
    //}

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "PanelTrigger")
        {
            //if (gameObject.name == "Panel_Floor")
            //{
            //    bool panelBelowUnit = DetermineIfPanelIsLowerThanUnit();
            //    float camVertAngle = PlayerManager.CameraAgent.Camera_Pivot.CameraVerticalAngle;

            //    if (camVertAngle < 0)
            //    {
            //        if (!panelBelowUnit)
            //        {
                        GoHalfTransparent();
            //        }
            //        else
            //        {
            //            GoNotTransparent();
            //        }
            //    }
            //}
        }
        if (other.name == "PanelTriggerCore")
        {
            //if (gameObject.name == "Panel_Floor")
            //{
            //    bool panelBelowUnit = DetermineIfPanelIsLowerThanUnit();
            //    float camVertAngle = PlayerManager.CameraAgent.Camera_Pivot.CameraVerticalAngle;

            //    if (camVertAngle > 0)
            //    {
            //        if (panelBelowUnit)
            //        {
                        GoFullTransparent();
            //        }
            //        else
            //        {
            //            GoHalfTransparent();
            //        }
            //    }
            //}
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "PanelTrigger")
        {
            GoNotTransparent();
        }
        if (other.name == "PanelTriggerCore")
        {
            GoHalfTransparent();
        }
    }


}
