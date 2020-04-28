using UnityEngine;

public class CameraPivot : MonoBehaviour
{
    ////////////////////////////////////////////////

    private Transform _cameraContainer;

    private Transform _panelTriggerCore;
    private Transform _panelTrigger;

    private float mouseRotationSpeed = 10f;                         // Horizontal turn speed.
    private float keysMovementSpeed = 1.0f;                           // Vertical turn speed.

    private float zoomMinFOV = 15f;
    private float zoomMaxFOV = 90f;
    private float zoomSensitivity = 10f;

    private float smooth = 10f;                                         // Speed of camera responsiveness.

    private float maxVerticalAngle = 50f;                               // Camera max clamp angle. 
    private float minVerticalAngle = -50f;                                 // Camera min clamp angle.

    private float h;
    private float v;
    private float x;
    private float y;

    public float angleH = 0;                                          // Float to store camera horizontal angle related to mouse movement.
    public float angleV = 0;                                          // Float to store camera vertical angle related to mouse movement.

    public float freeRoamAngleH = 0;                                           // Float to store camera horizontal angle related to mouse movement.
    public float freeRoamAngleV = 0;                                           // Float to store camera vertical angle related to mouse movement.

    private float targetFOV;                                           // Target camera FIeld of View.
    private float targetMaxVerticalAngle;                              // Custom camera max vertical clamp angle. 


    public Transform CameraContainer
    {
        get { return _cameraContainer; }
        set { _cameraContainer = value; }
    }


    private bool freeRoamCamera = false;

    public bool CAMERA_MOVING = false;
    public static int CAMERA_STATE_GLOBAL = 0; // hopefully global rotations
    public static int CAMERA_STATE_LOCAL = 1; // hopefully local rotations

    private static int _cameraState;

    public static int CameraState
    {
        get { return _cameraState; }
        set { _cameraState = value; }
    }

    public static bool CameraStateIsLocal
    {
        get { return _cameraState == CAMERA_STATE_LOCAL; }
    }
    public static bool CameraStateIsGlobal
    {
        get { return _cameraState == CAMERA_STATE_GLOBAL; }
    }

    public float CameraVerticalAngle
    {
        get { return angleV; }
    }

    ////////////////////////////////////////////////

    private float _turnSpeed = 4.0f;

    private Vector3 _offset;

    private Transform playerPivotTrans;
    private Vector3 playerPivotRot;
    private Vector3 cameraPivotRot;
    private float distanceX;
    private float distanceY;

    ////////////////////////////////////////////////

    void Awake()
    {
        CameraContainer = transform.Find("CameraObject");
        if (CameraContainer == null) { Debug.LogError("We got a problem here"); }

        _panelTriggerCore = transform.FindDeepChild("PanelTriggerCore");
        if (_panelTriggerCore == null) { Debug.LogError("We got a problem here"); }

        _panelTrigger = transform.FindDeepChild("PanelTrigger");
        if (_panelTrigger == null) { Debug.LogError("We got a problem here"); }
    }

    void Start()
    {
        CameraState = CAMERA_STATE_GLOBAL;
    }

    /// <summary>
    ///  NOTES <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    /// 
    ///  after some testing I think.. that the best player unit contolling/camera movment might be...
    ///  
    /// Not holding anything should go to global nopn-local space camera, to be able to tell units where to go easily
    /// holding middle mouse button should go to 3rd person/1st person with local space camera. 
    /// 
    /// UPDATE!!!
    /// NO
    /// Not holding anything should be the eaasiest type of GAMEPLAY
    /// NOT holding anything should put the camera into LOCAL space following the unit. And then only use the side screen triggers to pivot around unit
    /// but then holding middle ouse button should camera into a global camera pivot setting to scan the horizon. This setting caould then be a screensaver thingy when user hasnt touched mouse for a while
    /// 
    /// </summary>

    ///////////////////////////////////////

    void FixedUpdate()
    {
        if (!PlayerManager.CameraAgent.isLocalPlayer) return;

        ///////////////////////////////////////

        // mouse look around
        x = Input.GetAxis("Mouse X");
        y = Input.GetAxis("Mouse Y");

        // Basic Movement Player //
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        if (freeRoamCamera)
        {
            // For Free Roam
            KeyboardMovement();

            if (Input.GetMouseButton(2))
            {
                // Get mouse movement to orbit the camera.
                freeRoamAngleH += Mathf.Clamp(x, -1, 1) * mouseRotationSpeed;
                freeRoamAngleV += Mathf.Clamp(y, -1, 1) * mouseRotationSpeed;

                // Set camera orientation..
                Quaternion aimRotation = Quaternion.Euler(-freeRoamAngleV, freeRoamAngleH, 0);
                transform.rotation = aimRotation;
            }
        }
        else
        {
            if (Input.GetMouseButton(2))
            {
                CameraMove();
            }
            else
            {
                CameraStop();
            }


            // Zoom
            var d = Input.GetAxis("Mouse ScrollWheel");
            if (d < 0f)
            {
                _offset = new Vector3(0, 0, -1); // y = 0.5f
            }
            else if (d > 0f)
            {
                _offset = new Vector3(0, 0, 1); // y = -0.5f
            }
            PlayerManager.CameraAgent.CameraContainer.transform.localPosition += _offset;
            _offset = Vector3Int.zero;
        }
    }

    ///////////////////////////////////////
    void CameraMove()
    {
        CAMERA_MOVING = true;

        if (playerPivotTrans)
        {
            float cameraX = x;
            float cameraY = y;

            Vector3 cameraContainerAngle = CameraContainer.transform.localEulerAngles;
            int unitAngle = UnitsManager.ActiveUnit.UnitAngle;

            if (CameraStateIsGlobal)
            {
                cameraX = x;
                cameraY = y;

                angleH += Mathf.Clamp(cameraX, -1, 1) * mouseRotationSpeed;
                angleV += Mathf.Clamp(cameraY, -1, 1) * mouseRotationSpeed;

                // couple max distance measures
                if (angleV >= maxVerticalAngle)
                    angleV = maxVerticalAngle;

                if (angleV <= minVerticalAngle)
                    angleV = minVerticalAngle;
                ///////

                float angH = angleH;
                float angV = angleV;

                // Set camera orientation..
                if (x != 0 || y != 0)
                {
                    if (unitAngle == 0)
                        angV = -angleV; //angV = 0; //Change this back if dont want x and y rotation

                    if (unitAngle == 45)
                        angV = -angleV;

                    if (unitAngle == 90)
                        angV = -angleV;


                    Quaternion aimRotation = Quaternion.Euler(angV, angH, 0);
                    transform.rotation = aimRotation;
                }

                // To Stop camera always sticking to World Y Axis
                transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0);  //transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0); //Change this back if dont want x and y rotation
            }
            else
            {
                if (unitAngle == 0)
                {
                    cameraX = x;
                    cameraY = y;

                    angleH += Mathf.Clamp(cameraX, -1, 1) * mouseRotationSpeed;
                    angleV += Mathf.Clamp(cameraY, -1, 1) * mouseRotationSpeed;

                    // Set camera orientation..
                    if (x != 0 || y != 0)
                    {
                        Quaternion aimRotation = Quaternion.Euler(0, angleH, 0);
                        transform.rotation = aimRotation;
                    }

                    // To Stop camera always sticking to World Y Axis
                    transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);
                }
                else if (unitAngle == 45)
                {
                    cameraX = x;
                    cameraY = y;
                    transform.localEulerAngles = new Vector3(0, 0, 0);
                    CameraContainer.transform.localEulerAngles = new Vector3(cameraContainerAngle.x, cameraContainerAngle.y, -unitAngle);
                }
                else if (unitAngle == 90)
                {
                    cameraX = x;
                    cameraY = y;

                    angleH += Mathf.Clamp(cameraY, -1, 1) * mouseRotationSpeed;
                    angleV += Mathf.Clamp(cameraX, -1, 1) * mouseRotationSpeed;

                    // Set camera orientation..
                    if (x != 0 || y != 0)
                    {
                        Quaternion aimRotation = Quaternion.Euler(-angleV, angleH, 0);
                        transform.rotation = aimRotation;
                    }

                    // To Stop camera always sticking to World Y Axis
                    transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);

                }
            }
        }
    }

    void CameraStop()
    {
        CAMERA_MOVING = false;

        if (playerPivotTrans)
        {
            // Saving Camera position
            // Save distance between player pivot and cameraPivot Angles to apply later when mouse moved after a while (90% working)
            playerPivotRot = playerPivotTrans.eulerAngles;

            distanceX = playerPivotRot.x - angleH;
            distanceY = playerPivotRot.y - angleV;
        }
    }

    ///////////////////////////////////////

    void CameraSideSpin(int direction)
    {
        // Set camera orientation..
        Quaternion aimRotation = Quaternion.Euler(0, direction, 0);
        transform.rotation = aimRotation;

        PlayerManager.CameraAgent.CameraContainer.transform.LookAt(transform.position, Vector3Int.up);
    }

    ///////////////////////////////////////

    void KeyboardMovement()
    {
        if (freeRoamCamera)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                keysMovementSpeed = 5.0f;
            }
            else
            {
                keysMovementSpeed = 1.0f;
            }

            //Sets x and y basic movement
            transform.Translate(new Vector3(keysMovementSpeed * h, 0, 0));
            transform.Translate(new Vector3(0, 0, keysMovementSpeed * v));
        }
    }

    ///////////////////////////////////////

    // need a smooth transition when camera moves from unit to unit here, not just jump suddenly
    public void SetNewPivot(GameObject pivot)
    {
        transform.position = pivot.transform.position;

        if (freeRoamCamera)
        {
            SetFreeRoamCamera();
            return;
        }

        transform.SetParent(pivot.transform);
        transform.localPosition = Vector3Int.zero;

        playerPivotTrans = pivot.transform;

        PlayerManager.CameraAgent.CameraContainer.transform.localPosition = new Vector3Int(0, 0, -7); // y = 4
       // PlayerManager.CameraAgent.CameraContainer.transform.localEulerAngles = new Vector3Int(13, 0, 0);
    }

    public void SetFreeRoamCamera()
    {
        transform.SetParent(PlayerManager.PlayerAgent.gameObject.transform);
        transform.localPosition = Vector3Int.zero;
        transform.localEulerAngles = Vector3Int.zero;

        PlayerManager.CameraAgent.CameraContainer.transform.localPosition = Vector3Int.zero;
        PlayerManager.CameraAgent.CameraContainer.transform.localEulerAngles = Vector3Int.zero;
        CameraMove();
    }

}

