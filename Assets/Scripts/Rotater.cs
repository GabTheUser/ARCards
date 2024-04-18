using UnityEngine;
using UnityEngine.UI;

public class Rotater : MonoBehaviour
{
    public Material fontMat;
    [HideInInspector] public Transform objToRotate;
    public float rotSpeed, rotWithButtonSpeed, uiRotSpeed, sizeSpeed;
    float startZ;
    [HideInInspector] public bool up, down, right, left, scaleUp, scaleDown;
    bool rotateToRot, rotateToScale, backToMain;
    public GameObject mainButtons, RotateButtons, SizeButtons, buttonContainer, materialObj;
    public Button[] allButtons;


    // private float _sensitivity;
    [HideInInspector]public Vector3 _mouseReference;
    private Vector3 _mouseOffset;
    private Vector3 _rotation;
    [HideInInspector] public bool _isRotating;

    public float zoomOutMin;
    public float zoomOutMax; 

    // Update is called once per frame
    public void Start()
    {
        
        fontMat = materialObj.GetComponent<MeshRenderer>().material;
        startZ = buttonContainer.transform.eulerAngles.z;
    }
    void Update()
    {
        if (up == true) objToRotate.Rotate(rotWithButtonSpeed * Time.deltaTime, 0, 0);
        if (down == true) objToRotate.Rotate(-rotWithButtonSpeed * Time.deltaTime, 0, 0);
        if (left == true) objToRotate.Rotate(0, rotWithButtonSpeed * Time.deltaTime, 0);
        if (right == true) objToRotate.Rotate(0, -rotWithButtonSpeed * Time.deltaTime, 0);
        if (scaleUp == true)
            if (objToRotate.localScale.x <= 1.1f && objToRotate.localScale.y <= 1.1f && objToRotate.localScale.z <= 1.1f) objToRotate.localScale = new Vector3(objToRotate.localScale.x + sizeSpeed * Time.deltaTime, objToRotate.localScale.y + sizeSpeed * Time.deltaTime, objToRotate.localScale.z + sizeSpeed * Time.deltaTime);
        if (scaleDown == true)
            if(objToRotate.localScale.x> 0.5f && objToRotate.localScale.y > 0.5f && objToRotate.localScale.z > 0.5f) objToRotate.localScale = new Vector3(objToRotate.localScale.x - sizeSpeed * Time.deltaTime, objToRotate.localScale.y - sizeSpeed * Time.deltaTime, objToRotate.localScale.z - sizeSpeed * Time.deltaTime);
        if (rotateToRot == true)
        {
            if (backToMain == false)
            {
                if (buttonContainer.transform.localEulerAngles.z < 90)
                {
                    buttonContainer.transform.Rotate(0, 0, uiRotSpeed * Time.deltaTime);
                    Debug.Log(buttonContainer.transform.rotation.z);
                }
                else
                {
                    Debug.LogWarning(buttonContainer.transform.localEulerAngles.z);
                    buttonContainer.transform.localEulerAngles = new Vector3(0, 0, 90);
                    Debug.LogWarning(buttonContainer.transform.localEulerAngles.z);
                    rotateToRot = false;
                    mainButtons.SetActive(false);
                }
            }
            else if (rotateToRot == true && backToMain == true)
            {
                if (buttonContainer.transform.localEulerAngles.z > 22f)
                {
                    Debug.LogWarning(buttonContainer.transform.localEulerAngles.z+" im  trying") ;
                    buttonContainer.transform.Rotate(0, 0, -uiRotSpeed * Time.deltaTime);
                }
                else
                {
                    buttonContainer.transform.localEulerAngles = new Vector3(0, 0, 0);
                    Debug.LogWarning(buttonContainer.transform.localEulerAngles.z + " im  failing");
                    Debug.LogWarning(buttonContainer.transform.rotation.z);
                    rotateToRot = false;
                    RotateButtons.SetActive(false);
                }
            }
        }


        if (rotateToScale == true)
        {
            if (backToMain == false)
            {
                if (buttonContainer.transform.localEulerAngles.z < 90)
                {
                    buttonContainer.transform.Rotate(0, 0, uiRotSpeed * Time.deltaTime);
                }
                else
                {
                    buttonContainer.transform.localEulerAngles = new Vector3(0, 0, 90);
                    rotateToScale = false;
                    mainButtons.SetActive(false);
                }
            }
            else if (rotateToScale == true && backToMain == true)
            {
                if (buttonContainer.transform.localEulerAngles.z > 22f)
                {
                    buttonContainer.transform.Rotate(0, 0, -uiRotSpeed * Time.deltaTime);
                }
                else
                {
                    buttonContainer.transform.localEulerAngles = new Vector3(0, 0, 0);
                    rotateToScale = false;
                    SizeButtons.SetActive(false);
                }
            }
        }

        if (rotateToRot == false && rotateToScale == false && allButtons[allButtons.Length - 1].interactable == false)
            for (int i = 0; i <= allButtons.Length - 1; i++)
            {
                allButtons[i].interactable = true;
            }

        if (objToRotate != null)
        {
            if (_isRotating)
            {
                float rotX = Input.GetAxis("Mouse X") * rotSpeed;
                float rotY = Input.GetAxis("Mouse Y") * rotSpeed;
                Camera camera = Camera.main;
                Vector3 right = Vector3.Cross(camera.transform.up, objToRotate.position - camera.transform.position);
                Vector3 up = Vector3.Cross(objToRotate.position - camera.transform.position, right);
                objToRotate.rotation = Quaternion.AngleAxis(-rotX, up) * objToRotate.rotation;
                objToRotate.rotation = Quaternion.AngleAxis(rotY, right) * objToRotate.rotation;
            }
        }

        if (objToRotate != null)
            if (Input.touchCount == 2)
            {
                Touch touchZero = Input.GetTouch(0);
                Touch touchOne = Input.GetTouch(1);

                Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
                Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

                float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;
                float currentMagnitude = (touchZero.position - touchOne.position).magnitude;

                float difference = currentMagnitude - prevMagnitude;

                ScaleUpObj(difference * -0.01f);
            }
    }

    void ScaleUpObj(float increment)
    {
        objToRotate.localScale = new Vector3(Mathf.Clamp(objToRotate.localScale.x - increment, zoomOutMin, zoomOutMax), Mathf.Clamp(objToRotate.localScale.y - increment, zoomOutMin, zoomOutMax), Mathf.Clamp(objToRotate.localScale.z - increment, zoomOutMin, zoomOutMax));
    }

    public void DefRotation()
    {
       objToRotate.rotation = Quaternion.Euler(0, 0, 0);
    }

    public void CancelSelection()
    {
        if (objToRotate.GetComponentInParent<ObjectsScript>().infoObj != null)
            objToRotate.GetComponentInParent<ObjectsScript>().infoObj.SetActive(false);
        objToRotate = null; 
        FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
        FindObjectOfType<RayCaster>().selectedObject = null;
        FindObjectOfType<RayCaster>().buttons.SetActive(false);        
    }

    public void TurnInfoOn()
    {
        if (objToRotate.GetComponentInParent<ObjectsScript>().infoObj != null)
        {
            if (objToRotate.GetComponentInParent<ObjectsScript>().infoObj.activeSelf == false)
            {
               objToRotate.GetComponentInParent<ObjectsScript>().infoObj.GetComponentInChildren<MeshRenderer>().material = fontMat; 
               objToRotate.GetComponentInParent<ObjectsScript>().infoObj.SetActive(true);
            }
            else objToRotate.GetComponentInParent<ObjectsScript>().infoObj.SetActive(false);
        }
    }

    public void TurnRotationButtons()
    {
        for (int i = 0; i <= allButtons.Length - 1; i++)
        {
            allButtons[i].interactable = false;
        }
        backToMain = false;
        rotateToRot = true;      
        RotateButtons.SetActive(true);
    }
    public void TurnOffRotationButtons()
    {
        for (int i = 0; i <= allButtons.Length - 1; i++)
        {
            allButtons[i].interactable = false;
        }
        backToMain = true;
        mainButtons.SetActive(true);
        rotateToRot = true;
    }

    public void TurnSizeButtons()
    {
        for(int i=0; i <= allButtons.Length - 1; i++)
        {
            allButtons[i].interactable=false;
        }
        backToMain = false;
        rotateToScale = true;
        SizeButtons.SetActive(true);
    }
    public void TurnOffSizeButtons()
    {
        for (int i = 0; i <= allButtons.Length - 1; i++)
        {
            allButtons[i].interactable = false;
        }
        backToMain = true;
        mainButtons.SetActive(true);
        rotateToScale = true;
    }
   
}
