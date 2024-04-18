using UnityEngine;

public class RayCaster : MonoBehaviour
{
    public Transform selectedObject;
    public GameObject rotater, buttons, breakButton, mainCard;
    int currentlyOn;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.collider.gameObject.name);
                if (hit.collider.gameObject.tag == "Object")
                {
                    hit.collider.gameObject.GetComponentInParent<CardMain>().chosen = true;
                    Debug.Log(hit.collider.gameObject.name);
                    selectedObject = hit.collider.gameObject.transform;
                    selectedObject.GetComponentInParent<ObjectsScript>().flashTime = selectedObject.GetComponentInParent<ObjectsScript>().maxFlashTime;
                    selectedObject.GetComponentInParent<ObjectsScript>().mesh = selectedObject.GetComponentsInChildren<MeshRenderer>();
                    foreach (MeshRenderer meshR in selectedObject.GetComponentInParent<ObjectsScript>().mesh)
                    {
                        if (meshR.gameObject.name != "Text")
                            meshR.material = selectedObject.GetComponentInParent<ObjectsScript>().pickColors;
                    }
                    CheckIfBBneed();
                    FindObjectOfType<Rotater>().objToRotate = selectedObject;
                    buttons.SetActive(true);
                }
            }
            
        }

        if (selectedObject != null)
        {
            if (mainCard.GetComponent<CardMain>().transformations[25].activeSelf == true)
            {
                float dist = Vector3.Distance(mainCard.GetComponent<CardMain>().transform.position, transform.position);
                if(dist < 4.5f)
                {
                    mainCard.GetComponent<CardMain>().transformations[25].GetComponent<Animator>().SetBool("breaking", true);
                }
                else
                {
                    mainCard.GetComponent<CardMain>().transformations[25].GetComponent<Animator>().SetBool("breaking", false);
                }
            }
        }
    }

    public void ObjectGoneInvis()
    {
        if (selectedObject != null)
        {
            selectedObject = null;
            FindObjectOfType<Rotater>().objToRotate = null;
            buttons.SetActive(false);
        }
    }
   
    public void CheckIfBBneed()
    {
        currentlyOn = 0;
        if (selectedObject != null)
        {
            if (selectedObject.GetComponentInParent<CardMain>().transformations.Length > 1)
            {
                for (int i = 0; i <= selectedObject.GetComponentInParent<CardMain>().transformations.Length - 1; i++)
                {

                    Debug.LogWarning("start");

                    if (selectedObject.GetComponentInParent<CardMain>().transformations[i].activeSelf == true)
                    {
                        currentlyOn = i;
                        if (currentlyOn > 0)
                        {
                            breakButton.SetActive(true);
                        }
                        else
                        {
                            breakButton.SetActive(false);
                        }
                        i = selectedObject.GetComponentInParent<CardMain>().transformations.Length;
                    }
                }
            }
        }
    }
}
