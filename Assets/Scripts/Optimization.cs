using System;
using UnityEngine;

public class Optimization : MonoBehaviour
{
    public int currentTransform, numCombineBreak;
    public GameObject[] colldingObjects;
    public GameObject[] currentlyBreaking;
    public string[] currentlyColliding; // names of colliding objects used to find if they can connect
    public GameObject mainCard;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Combine()
    {

    }

    void Break()
    {

    }


    void LOOL()
    {

        if (currentlyColliding[0] != "" && currentlyColliding[1] != "")
        {
            // 1st combo = = = = = = = =
            if ((currentlyColliding[0] == "part1" && currentlyColliding[1] == "part2") || (currentlyColliding[0] == "part2" && currentlyColliding[1] == "part1"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part1")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[1].SetActive(true); // must be changed   
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[1].transform; // must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[1].transform; // must be changed                        
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part3"; // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false); // must be changed
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part1")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[1].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[1].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[1].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part3"; // must be changed
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 2nd combo = = = = = =
            else if ((currentlyColliding[0] == "part3" && currentlyColliding[1] == "part4") || (currentlyColliding[0] == "part4" && currentlyColliding[1] == "part3"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part3")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[2].transform.localScale = mainCard.GetComponent<CardMain>().transformations[1].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[2].transform.rotation = mainCard.GetComponent<CardMain>().transformations[1].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[2].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[2].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[2].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part5"; // must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[1].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part3")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[2].transform.localScale = mainCard.GetComponent<CardMain>().transformations[1].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[2].transform.rotation = mainCard.GetComponent<CardMain>().transformations[1].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[2].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[2].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[2].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part5";// must be changed
                                                                                       //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[1].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 3d combo = = = = = = 
            else if ((currentlyColliding[0] == "part5" && currentlyColliding[1] == "part6") || (currentlyColliding[0] == "part6" && currentlyColliding[1] == "part5"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part5")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[3].transform.localScale = mainCard.GetComponent<CardMain>().transformations[2].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[3].transform.rotation = mainCard.GetComponent<CardMain>().transformations[2].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[3].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[3].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[3].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part7"; // must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[2].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part5")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[3].transform.localScale = mainCard.GetComponent<CardMain>().transformations[2].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[3].transform.rotation = mainCard.GetComponent<CardMain>().transformations[2].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[3].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[3].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[3].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part7";// must be changed
                                                                                       //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[2].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 4 combo = = = = = = 
            else if ((currentlyColliding[0] == "part7" && currentlyColliding[1] == "part8") || (currentlyColliding[0] == "part8" && currentlyColliding[1] == "part7"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part7")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[4].transform.localScale = mainCard.GetComponent<CardMain>().transformations[3].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[4].transform.rotation = mainCard.GetComponent<CardMain>().transformations[3].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[4].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[4].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[4].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part9"; // must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[3].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part9")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[4].transform.localScale = mainCard.GetComponent<CardMain>().transformations[3].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[4].transform.rotation = mainCard.GetComponent<CardMain>().transformations[3].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[4].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[4].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[4].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part9";// must be changed
                                                                                       //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[3].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 5 combo = = = = = = 
            else if ((currentlyColliding[0] == "part9" && currentlyColliding[1] == "part10") || (currentlyColliding[0] == "part10" && currentlyColliding[1] == "part9"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part9")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[5].transform.localScale = mainCard.GetComponent<CardMain>().transformations[4].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[5].transform.rotation = mainCard.GetComponent<CardMain>().transformations[4].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[5].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[5].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[5].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part11"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[4].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part11")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[5].transform.localScale = mainCard.GetComponent<CardMain>().transformations[4].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[5].transform.rotation = mainCard.GetComponent<CardMain>().transformations[4].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[5].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[5].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[5].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part11";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[4].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 6 combo = = = = = = 
            else if ((currentlyColliding[0] == "part11" && currentlyColliding[1] == "part12") || (currentlyColliding[0] == "part12" && currentlyColliding[1] == "part11"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part11")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[6].transform.localScale = mainCard.GetComponent<CardMain>().transformations[5].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[6].transform.rotation = mainCard.GetComponent<CardMain>().transformations[5].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[6].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[6].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[6].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part13"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[5].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part11")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[6].transform.localScale = mainCard.GetComponent<CardMain>().transformations[5].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[6].transform.rotation = mainCard.GetComponent<CardMain>().transformations[5].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[6].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[6].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[6].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part13";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[5].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 7 combo = = = = = = 
            else if ((currentlyColliding[0] == "part13" && currentlyColliding[1] == "part14") || (currentlyColliding[0] == "part14" && currentlyColliding[1] == "part13"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part13")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[7].transform.localScale = mainCard.GetComponent<CardMain>().transformations[6].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[7].transform.rotation = mainCard.GetComponent<CardMain>().transformations[6].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[7].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[7].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[7].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part15"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[6].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part13")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[7].transform.localScale = mainCard.GetComponent<CardMain>().transformations[6].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[7].transform.rotation = mainCard.GetComponent<CardMain>().transformations[6].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[7].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[7].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[7].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part15";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[6].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 8 combo = = = = = = 
            else if ((currentlyColliding[0] == "part15" && currentlyColliding[1] == "part16") || (currentlyColliding[0] == "part16" && currentlyColliding[1] == "part15"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part15")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[8].transform.localScale = mainCard.GetComponent<CardMain>().transformations[7].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[8].transform.rotation = mainCard.GetComponent<CardMain>().transformations[7].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[8].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[8].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[8].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part17"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[7].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part15")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[8].transform.localScale = mainCard.GetComponent<CardMain>().transformations[7].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[8].transform.rotation = mainCard.GetComponent<CardMain>().transformations[7].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[8].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[8].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[8].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part17";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[7].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 9 combo = = = = = = 
            else if ((currentlyColliding[0] == "part17" && currentlyColliding[1] == "part18") || (currentlyColliding[0] == "part18" && currentlyColliding[1] == "part17"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part17")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[9].transform.localScale = mainCard.GetComponent<CardMain>().transformations[8].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[9].transform.rotation = mainCard.GetComponent<CardMain>().transformations[8].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[9].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[9].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[9].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part19"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[8].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part17")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[9].transform.localScale = mainCard.GetComponent<CardMain>().transformations[8].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[9].transform.rotation = mainCard.GetComponent<CardMain>().transformations[8].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[9].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[9].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[9].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part19";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[8].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 10 combo = = = = = = 
            else if ((currentlyColliding[0] == "part19" && currentlyColliding[1] == "part20") || (currentlyColliding[0] == "part20" && currentlyColliding[1] == "part19"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part19")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[10].transform.localScale = mainCard.GetComponent<CardMain>().transformations[9].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[10].transform.rotation = mainCard.GetComponent<CardMain>().transformations[9].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[10].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[10].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[10].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part21"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[9].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part19")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[10].transform.localScale = mainCard.GetComponent<CardMain>().transformations[9].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[10].transform.rotation = mainCard.GetComponent<CardMain>().transformations[9].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[10].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[10].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[10].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part21";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[9].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 11 combo = = = = = = 
            else if ((currentlyColliding[0] == "part21" && currentlyColliding[1] == "part22") || (currentlyColliding[0] == "part22" && currentlyColliding[1] == "part21"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part21")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[11].transform.localScale = mainCard.GetComponent<CardMain>().transformations[10].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[11].transform.rotation = mainCard.GetComponent<CardMain>().transformations[10].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[11].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[11].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[11].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part23"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[10].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part21")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[11].transform.localScale = mainCard.GetComponent<CardMain>().transformations[10].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[11].transform.rotation = mainCard.GetComponent<CardMain>().transformations[10].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[11].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[11].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[11].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part23";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[10].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 12 combo = = = = = = 
            else if ((currentlyColliding[0] == "part23" && currentlyColliding[1] == "part24") || (currentlyColliding[0] == "part24" && currentlyColliding[1] == "part23"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part23")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[12].transform.localScale = mainCard.GetComponent<CardMain>().transformations[11].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[12].transform.rotation = mainCard.GetComponent<CardMain>().transformations[11].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[12].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[12].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[12].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part25"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[11].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part23")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[12].transform.localScale = mainCard.GetComponent<CardMain>().transformations[11].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[12].transform.rotation = mainCard.GetComponent<CardMain>().transformations[11].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[12].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[12].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[12].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part25";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[11].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 13 combo = = = = = = 
            else if ((currentlyColliding[0] == "part25" && currentlyColliding[1] == "part26") || (currentlyColliding[0] == "part26" && currentlyColliding[1] == "part25"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part25")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[13].transform.localScale = mainCard.GetComponent<CardMain>().transformations[12].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[13].transform.rotation = mainCard.GetComponent<CardMain>().transformations[12].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[13].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[13].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[13].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part27"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[12].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part25")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[13].transform.localScale = mainCard.GetComponent<CardMain>().transformations[12].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[13].transform.rotation = mainCard.GetComponent<CardMain>().transformations[12].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[13].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[13].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[13].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part27";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[12].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 14 combo = = = = = = 
            else if ((currentlyColliding[0] == "part27" && currentlyColliding[1] == "part28") || (currentlyColliding[0] == "part28" && currentlyColliding[1] == "part27"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part27")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[14].transform.localScale = mainCard.GetComponent<CardMain>().transformations[13].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[14].transform.rotation = mainCard.GetComponent<CardMain>().transformations[13].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[14].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[14].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[14].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part29"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[13].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part27")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[14].transform.localScale = mainCard.GetComponent<CardMain>().transformations[13].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[14].transform.rotation = mainCard.GetComponent<CardMain>().transformations[13].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[14].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[14].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[14].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part29";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[13].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 15 combo = = = = = = 
            else if ((currentlyColliding[0] == "part29" && currentlyColliding[1] == "part30") || (currentlyColliding[0] == "part30" && currentlyColliding[1] == "part29"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part29")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[15].transform.localScale = mainCard.GetComponent<CardMain>().transformations[14].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[15].transform.rotation = mainCard.GetComponent<CardMain>().transformations[14].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[15].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[15].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[15].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part31"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[14].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part29")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[15].transform.localScale = mainCard.GetComponent<CardMain>().transformations[14].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[15].transform.rotation = mainCard.GetComponent<CardMain>().transformations[14].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[15].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[15].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[15].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part31";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[14].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 16 combo = = = = = = 
            else if ((currentlyColliding[0] == "part31" && currentlyColliding[1] == "part32") || (currentlyColliding[0] == "part32" && currentlyColliding[1] == "part31"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part31")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[16].transform.localScale = mainCard.GetComponent<CardMain>().transformations[15].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[16].transform.rotation = mainCard.GetComponent<CardMain>().transformations[15].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[16].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[16].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[16].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part33"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[15].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part31")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[16].transform.localScale = mainCard.GetComponent<CardMain>().transformations[15].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[16].transform.rotation = mainCard.GetComponent<CardMain>().transformations[15].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[16].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[16].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[16].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part33";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[15].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 17 combo = = = = = = 
            else if ((currentlyColliding[0] == "part33" && currentlyColliding[1] == "part34") || (currentlyColliding[0] == "part34" && currentlyColliding[1] == "part33"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part33")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[17].transform.localScale = mainCard.GetComponent<CardMain>().transformations[16].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[17].transform.rotation = mainCard.GetComponent<CardMain>().transformations[16].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[17].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[17].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[17].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part35"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[16].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part33")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[17].transform.localScale = mainCard.GetComponent<CardMain>().transformations[16].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[17].transform.rotation = mainCard.GetComponent<CardMain>().transformations[16].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[17].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[17].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[17].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part35";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[16].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 18 combo = = = = = = 
            else if ((currentlyColliding[0] == "part35" && currentlyColliding[1] == "part36") || (currentlyColliding[0] == "part36" && currentlyColliding[1] == "part35"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part35")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[18].transform.localScale = mainCard.GetComponent<CardMain>().transformations[17].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[18].transform.rotation = mainCard.GetComponent<CardMain>().transformations[17].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[18].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[18].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[18].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part37"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[17].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part35")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[18].transform.localScale = mainCard.GetComponent<CardMain>().transformations[17].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[18].transform.rotation = mainCard.GetComponent<CardMain>().transformations[17].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[18].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[18].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[18].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part37";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[17].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 19 combo = = = = = = 
            else if ((currentlyColliding[0] == "part37" && currentlyColliding[1] == "part38") || (currentlyColliding[0] == "part38" && currentlyColliding[1] == "part37"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part37")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[19].transform.localScale = mainCard.GetComponent<CardMain>().transformations[18].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[19].transform.rotation = mainCard.GetComponent<CardMain>().transformations[18].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[19].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[19].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[19].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part39"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[18].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part37")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[19].transform.localScale = mainCard.GetComponent<CardMain>().transformations[18].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[19].transform.rotation = mainCard.GetComponent<CardMain>().transformations[18].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[19].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[19].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[19].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part39";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[18].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 20 combo = = = = = = 
            else if ((currentlyColliding[0] == "part39" && currentlyColliding[1] == "part40") || (currentlyColliding[0] == "part40" && currentlyColliding[1] == "part39"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part39")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[20].transform.localScale = mainCard.GetComponent<CardMain>().transformations[19].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[20].transform.rotation = mainCard.GetComponent<CardMain>().transformations[19].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[20].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[20].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[20].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part41"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[19].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part39")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[20].transform.localScale = mainCard.GetComponent<CardMain>().transformations[19].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[20].transform.rotation = mainCard.GetComponent<CardMain>().transformations[19].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[20].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[20].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[20].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part41";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[19].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 21 combo = = = = = = 
            else if ((currentlyColliding[0] == "part41" && currentlyColliding[1] == "part42") || (currentlyColliding[0] == "part42" && currentlyColliding[1] == "part41"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part41")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[21].transform.localScale = mainCard.GetComponent<CardMain>().transformations[20].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[21].transform.rotation = mainCard.GetComponent<CardMain>().transformations[20].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[21].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[21].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[21].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part43"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[20].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part41")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[21].transform.localScale = mainCard.GetComponent<CardMain>().transformations[20].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[21].transform.rotation = mainCard.GetComponent<CardMain>().transformations[20].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[21].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[21].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[21].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part43";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[20].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 22 combo = = = = = = 
            else if ((currentlyColliding[0] == "part43" && currentlyColliding[1] == "part44") || (currentlyColliding[0] == "part44" && currentlyColliding[1] == "part43"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part43")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[22].transform.localScale = mainCard.GetComponent<CardMain>().transformations[21].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[22].transform.rotation = mainCard.GetComponent<CardMain>().transformations[21].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[22].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[22].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[22].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part45"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[21].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part43")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[22].transform.localScale = mainCard.GetComponent<CardMain>().transformations[21].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[22].transform.rotation = mainCard.GetComponent<CardMain>().transformations[21].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[22].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[22].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[22].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part45";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[21].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 23 combo = = = = = = 
            else if ((currentlyColliding[0] == "part45" && currentlyColliding[1] == "part46") || (currentlyColliding[0] == "part46" && currentlyColliding[1] == "part45"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part45")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[23].transform.localScale = mainCard.GetComponent<CardMain>().transformations[22].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[23].transform.rotation = mainCard.GetComponent<CardMain>().transformations[22].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[23].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[23].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[23].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part47"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[22].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part45")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[23].transform.localScale = mainCard.GetComponent<CardMain>().transformations[22].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[23].transform.rotation = mainCard.GetComponent<CardMain>().transformations[22].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[23].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[23].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[23].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part47";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[22].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 24 combo = = = = = = 
            else if ((currentlyColliding[0] == "part47" && currentlyColliding[1] == "part48") || (currentlyColliding[0] == "part48" && currentlyColliding[1] == "part47"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part47")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[24].transform.localScale = mainCard.GetComponent<CardMain>().transformations[23].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[24].transform.rotation = mainCard.GetComponent<CardMain>().transformations[23].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[24].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[24].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[24].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part49"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[23].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part47")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[24].transform.localScale = mainCard.GetComponent<CardMain>().transformations[23].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[24].transform.rotation = mainCard.GetComponent<CardMain>().transformations[23].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[24].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[24].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[24].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part49";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[23].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 25 combo = = = = = = 
            else if ((currentlyColliding[0] == "part49" && currentlyColliding[1] == "part50") || (currentlyColliding[0] == "part50" && currentlyColliding[1] == "part49"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part49")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[25].transform.localScale = mainCard.GetComponent<CardMain>().transformations[24].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[25].transform.rotation = mainCard.GetComponent<CardMain>().transformations[24].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[25].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[25].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[25].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part51"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[24].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part49")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[25].transform.localScale = mainCard.GetComponent<CardMain>().transformations[24].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[25].transform.rotation = mainCard.GetComponent<CardMain>().transformations[24].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[25].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[25].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[25].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part51";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[24].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 26 combo = = = = = = 
            else if ((currentlyColliding[0] == "part51" && currentlyColliding[1] == "part52") || (currentlyColliding[0] == "part52" && currentlyColliding[1] == "part51"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part51")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[26].transform.localScale = mainCard.GetComponent<CardMain>().transformations[25].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[26].transform.rotation = mainCard.GetComponent<CardMain>().transformations[25].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[26].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[26].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[26].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part53"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[25].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part51")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[26].transform.localScale = mainCard.GetComponent<CardMain>().transformations[25].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[26].transform.rotation = mainCard.GetComponent<CardMain>().transformations[25].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[26].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[26].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[26].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part53";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[25].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 27 combo = = = = = = 
            else if ((currentlyColliding[0] == "part53" && currentlyColliding[1] == "part54") || (currentlyColliding[0] == "part54" && currentlyColliding[1] == "part53"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part53")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[27].transform.localScale = mainCard.GetComponent<CardMain>().transformations[26].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[27].transform.rotation = mainCard.GetComponent<CardMain>().transformations[26].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[27].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[27].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[27].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part55"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[26].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part53")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[27].transform.localScale = mainCard.GetComponent<CardMain>().transformations[26].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[27].transform.rotation = mainCard.GetComponent<CardMain>().transformations[26].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[27].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[27].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[27].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part55";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[26].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 28 combo = = = = = = 
            else if ((currentlyColliding[0] == "part55" && currentlyColliding[1] == "part56") || (currentlyColliding[0] == "part56" && currentlyColliding[1] == "part55"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part55")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[28].transform.localScale = mainCard.GetComponent<CardMain>().transformations[27].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[28].transform.rotation = mainCard.GetComponent<CardMain>().transformations[27].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[28].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[28].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[28].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part57"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[27].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part55")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[28].transform.localScale = mainCard.GetComponent<CardMain>().transformations[27].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[28].transform.rotation = mainCard.GetComponent<CardMain>().transformations[27].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[28].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[28].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[28].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part57";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[27].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            // 29 combo = = = = = = 
            else if ((currentlyColliding[0] == "part57" && currentlyColliding[1] == "part58") || (currentlyColliding[0] == "part58" && currentlyColliding[1] == "part57"))
            {
                if (colldingObjects[0].GetComponent<CardMain>().myObjectName == "part57")
                {
                    colldingObjects[0].GetComponent<CardMain>().transformations[29].transform.localScale = mainCard.GetComponent<CardMain>().transformations[28].transform.localScale;
                    colldingObjects[0].GetComponent<CardMain>().transformations[29].transform.rotation = mainCard.GetComponent<CardMain>().transformations[28].transform.rotation;
                    colldingObjects[0].GetComponent<CardMain>().transformations[29].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[29].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[29].transform;// must be changed
                    }
                    colldingObjects[0].GetComponent<CardMain>().myObjectName = "part59"; // must be changed
                                                                                         //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false);
                    colldingObjects[0].GetComponent<CardMain>().transformations[28].SetActive(false); // must be changed
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
                else if (colldingObjects[1].GetComponent<CardMain>().myObjectName == "part57")
                {
                    colldingObjects[1].GetComponent<CardMain>().transformations[29].transform.localScale = mainCard.GetComponent<CardMain>().transformations[28].transform.localScale;
                    colldingObjects[1].GetComponent<CardMain>().transformations[29].transform.rotation = mainCard.GetComponent<CardMain>().transformations[28].transform.rotation;
                    colldingObjects[1].GetComponent<CardMain>().transformations[29].SetActive(true); // must be changed
                    if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                    {
                        FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[29].transform;// must be changed
                        FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[29].transform;// must be changed
                    }
                    colldingObjects[1].GetComponent<CardMain>().myObjectName = "part59";// must be changed
                                                                                        //=====================================================================================
                    colldingObjects[1].GetComponent<CardMain>().transformations[28].SetActive(false); // must be changed
                    colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false);
                    currentlyColliding[0] = "";
                    currentlyColliding[1] = "";
                    colldingObjects[0] = null;
                    colldingObjects[1] = null;

                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                }
            }
            else
            {
                currentlyColliding[0] = "";
                currentlyColliding[1] = "";
                colldingObjects[0] = null;
                colldingObjects[1] = null;
            }
        }
    }
    /*void KKKKK()
    {

        Debug.Log("entered");
        switch (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName)
        {
            case "part3":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[0].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[1].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[0].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[1].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[0].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[1].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part1";
                }
                if (currentlyBreaking[0].GetComponent<CardMain>().myObjectName == "part2")
                {
                    currentlyBreaking[0].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part5":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[1].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[2].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[1].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[2].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[1].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[2].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part3";
                }
                if (currentlyBreaking[1].GetComponent<CardMain>().myObjectName == "part4")
                {
                    currentlyBreaking[1].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part7":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[2].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[3].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[2].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[3].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[2].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[3].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part5";
                }
                if (currentlyBreaking[2].GetComponent<CardMain>().myObjectName == "part6")
                {
                    currentlyBreaking[2].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part9":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[3].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[4].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[3].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[4].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[3].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[4].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part7";
                }
                if (currentlyBreaking[3].GetComponent<CardMain>().myObjectName == "part8")
                {
                    currentlyBreaking[3].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part11":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[4].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[5].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[4].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[5].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[4].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[5].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part9";
                }
                if (currentlyBreaking[4].GetComponent<CardMain>().myObjectName == "part10")
                {
                    currentlyBreaking[4].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part13":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[5].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[6].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[5].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[6].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[5].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[6].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part11";
                }
                if (currentlyBreaking[5].GetComponent<CardMain>().myObjectName == "part12")
                {
                    currentlyBreaking[5].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part15":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[6].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[7].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[6].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[7].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[6].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[7].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part13";
                }
                if (currentlyBreaking[6].GetComponent<CardMain>().myObjectName == "part14")
                {
                    currentlyBreaking[6].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part17":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[7].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[8].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[7].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[8].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[7].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[8].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part15";
                }
                if (currentlyBreaking[7].GetComponent<CardMain>().myObjectName == "part16")
                {
                    currentlyBreaking[7].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part19":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[8].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[9].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[8].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[9].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[8].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[9].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part17";
                }
                if (currentlyBreaking[8].GetComponent<CardMain>().myObjectName == "part18")
                {
                    currentlyBreaking[8].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part21":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[9].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[10].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[9].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[10].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[9].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[10].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part19";
                }
                if (currentlyBreaking[9].GetComponent<CardMain>().myObjectName == "part20")
                {
                    currentlyBreaking[9].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part23":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[10].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[11].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[10].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[11].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[10].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[11].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part21";
                }
                if (currentlyBreaking[10].GetComponent<CardMain>().myObjectName == "part22")
                {
                    currentlyBreaking[10].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part25":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[11].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[12].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[11].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[12].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[11].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[12].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part23";
                }
                if (currentlyBreaking[11].GetComponent<CardMain>().myObjectName == "part24")
                {
                    currentlyBreaking[11].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part27":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[12].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[13].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[12].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[13].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[12].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[13].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part25";
                }
                if (currentlyBreaking[12].GetComponent<CardMain>().myObjectName == "part26")
                {
                    currentlyBreaking[12].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part29":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[13].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[14].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[13].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[14].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[13].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[14].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part27";
                }
                if (currentlyBreaking[13].GetComponent<CardMain>().myObjectName == "part28")
                {
                    currentlyBreaking[13].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part31":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[15].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[16].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[15].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[16].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[15].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[16].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part29";
                }
                if (currentlyBreaking[14].GetComponent<CardMain>().myObjectName == "part30")
                {
                    currentlyBreaking[14].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part33":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[16].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[17].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[16].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[17].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[16].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[17].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part31";
                }
                if (currentlyBreaking[15].GetComponent<CardMain>().myObjectName == "part32")
                {
                    currentlyBreaking[15].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part35":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[17].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[18].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[17].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[18].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[17].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[18].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part33";
                }
                if (currentlyBreaking[16].GetComponent<CardMain>().myObjectName == "part34")
                {
                    currentlyBreaking[16].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part37":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[18].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[19].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[18].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[19].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[18].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[19].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part35";
                }
                if (currentlyBreaking[17].GetComponent<CardMain>().myObjectName == "part36")
                {
                    currentlyBreaking[17].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part39":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[19].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[20].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[19].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[20].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[19].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[20].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part37";
                }
                if (currentlyBreaking[18].GetComponent<CardMain>().myObjectName == "part38")
                {
                    currentlyBreaking[18].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part41":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[20].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[21].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[20].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[21].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[20].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[21].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part39";
                }
                if (currentlyBreaking[19].GetComponent<CardMain>().myObjectName == "part40")
                {
                    currentlyBreaking[19].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part43":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[21].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[22].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[21].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[22].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[21].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[22].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part41";
                }
                if (currentlyBreaking[20].GetComponent<CardMain>().myObjectName == "part42")
                {
                    currentlyBreaking[20].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part45":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[22].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[23].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[22].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[23].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[22].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[23].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part43";
                }
                if (currentlyBreaking[21].GetComponent<CardMain>().myObjectName == "part44")
                {
                    currentlyBreaking[21].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part47":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[23].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[24].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[23].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[24].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[23].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[24].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part45";
                }
                if (currentlyBreaking[22].GetComponent<CardMain>().myObjectName == "part46")
                {
                    currentlyBreaking[23].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part49":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[24].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[25].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[24].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[25].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[24].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[25].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part47";
                }
                if (currentlyBreaking[24].GetComponent<CardMain>().myObjectName == "part48")
                {
                    currentlyBreaking[24].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part51":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[25].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[26].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[25].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[26].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[25].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[26].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part49";
                }
                if (currentlyBreaking[25].GetComponent<CardMain>().myObjectName == "part50")
                {
                    currentlyBreaking[25].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part53":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[26].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[27].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[26].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[27].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[26].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[27].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part51";
                }
                if (currentlyBreaking[26].GetComponent<CardMain>().myObjectName == "part52")
                {
                    currentlyBreaking[26].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part55":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[27].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[28].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[27].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[28].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[27].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[28].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part53";
                }
                if (currentlyBreaking[27].GetComponent<CardMain>().myObjectName == "part54")
                {
                    currentlyBreaking[27].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
            case "part57":
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().firstFullPart == true)
                {

                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[28].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[29].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[28].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[29].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[28].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[29].SetActive(false);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = "part55";
                }
                if (currentlyBreaking[28].GetComponent<CardMain>().myObjectName == "part56")
                {
                    currentlyBreaking[28].GetComponent<CardMain>().transformations[0].SetActive(true);
                }
                FindObjectOfType<RayCaster>().CheckIfBBneed();
                FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                FindObjectOfType<RayCaster>().selectedObject = null;
                FindObjectOfType<Rotater>().objToRotate = null;
                FindObjectOfType<RayCaster>().buttons.SetActive(false);
                break;
        }

    }

}
*/
}