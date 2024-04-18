//This script is made for cards so they know what what object they own and it must help CombineLogic.cs
using UnityEngine;

public class CardMain : MonoBehaviour
{
    public bool chosen;
    public string myObjectName, mainObjectNum;
    public GameObject[] transformations;

    public AnimationClip[] animations;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name);

        if (other.gameObject.CompareTag("Card") && gameObject.CompareTag("Card"))
        {
            FindObjectOfType<CombineLogic>().colldingObjects[0] = gameObject;
            FindObjectOfType<CombineLogic>().colldingObjects[1] = other.gameObject;
            FindObjectOfType<CombineLogic>().currentlyColliding[0] = myObjectName;
            FindObjectOfType<CombineLogic>().currentlyColliding[1] = other.gameObject.GetComponent<CardMain>().myObjectName;
            FindObjectOfType<CombineLogic>().Combine();
           
        }        
    }

}