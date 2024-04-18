using System;
using UnityEngine;
using UnityEngine.UI;

public class CombineLogic : MonoBehaviour
{
    public Text[] texts;
    public int currentTransform, numCombineBreak, currentTransform1, numCombineBreak1, currentTransform2, numCombineBreak2;
    public GameObject[] colldingObjects;
    public GameObject[] currentlyBreaking;
    public string[] currentlyColliding; // names of colliding objects used to find if they can connect
    public GameObject[] mainCard;

    private void Update()
    {
        texts[0].text = "cT " + currentTransform;
        texts[1].text = "cT1 " + currentTransform1;
        texts[2].text = "nB " + numCombineBreak;
        texts[3].text = "nB1 " + numCombineBreak1;
    }
    public void Combine()
    {
        // ====== First main card ==========                                                                                                            //can be changed
        if ((colldingObjects[0].GetComponent<CardMain>().mainObjectNum == "0" && Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName)<57) || (colldingObjects[1].GetComponent<CardMain>().mainObjectNum == "0" && Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) < 57))
        {
            if (currentlyColliding[0] != "" && currentlyColliding[1] != "" && mainCard[0].GetComponent<CardMain>().transformations[numCombineBreak + 2].activeSelf == false)
            {
                if ((Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) % 2 != 0 && Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) % 2 == 0) || (Convert.ToInt64(colldingObjects[1].GetComponent<CardMain>().myObjectName) % 2 != 0 && Convert.ToInt64(colldingObjects[0].GetComponent<CardMain>().myObjectName) % 2 == 0))
                {
                    //numCombineBreak++;
                    if (Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) == Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) + 1)
                    {
                        //Debug.LogWarning("first scenario");
                        //if (Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) != Convert.ToInt32(mainCard[0].GetComponent<CardMain>().myObjectName) + 1 && Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) >= Convert.ToInt32(mainCard[0].GetComponent<CardMain>().myObjectName) + 1)
                        //{

                        if (currentTransform > 2)
                        {
                            Debug.LogWarning("fir");
                            colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform].transform.localScale = mainCard[0].GetComponent<CardMain>().transformations[currentTransform - 1].transform.localScale;
                            colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform].transform.rotation = mainCard[0].GetComponent<CardMain>().transformations[currentTransform - 1].transform.rotation;
                        }
                        if (colldingObjects[0].GetComponent<CardMain>())
                            if (colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform] != null)
                                colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform].SetActive(true);
                        if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                        {
                            Debug.LogWarning("firaaaa");
                            FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform].transform; // must be changed
                            FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform].transform; // must be changed                        
                        }
                        colldingObjects[0].GetComponent<CardMain>().myObjectName = Convert.ToString(Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) + 1); // must be changed
                        colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform - 1].SetActive(false); // must be changed
                        colldingObjects[1].GetComponent<CardMain>().enabled = false;
                        colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false); // must be changed
                        currentlyColliding[0] = "";
                        currentlyColliding[1] = "";
                        colldingObjects[0] = null;
                        colldingObjects[1] = null;

                        if (currentTransform > 1) FindObjectOfType<RayCaster>().CheckIfBBneed();
                        numCombineBreak++;
                        currentTransform++;
                        //}
                    }
                    else if (Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) == Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) + 1)
                    {
                        Debug.LogWarning("second scenario" + colldingObjects[1].GetComponent<CardMain>().myObjectName + " << >>  " + Convert.ToInt32(mainCard[0].GetComponent<CardMain>().myObjectName) + 1);
                        // if (Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) >= Convert.ToInt32(mainCard[0].GetComponent<CardMain>().myObjectName) + 1 && Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) >= Convert.ToInt32(mainCard[0].GetComponent<CardMain>().myObjectName) + 1)
                        // {

                        if (currentTransform > 2)
                        {
                            Debug.LogWarning("sec");
                            colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform].transform.localScale = mainCard[0].GetComponent<CardMain>().transformations[currentTransform - 1].transform.localScale;
                            colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform].transform.rotation = mainCard[0].GetComponent<CardMain>().transformations[currentTransform - 1].transform.rotation;
                        }
                        if (colldingObjects[1].GetComponent<CardMain>())
                            if (colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform] != null)
                                colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform].SetActive(true); // must be changed
                        if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                        {
                            Debug.LogWarning("secaa");
                            FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform].transform;// must be changed
                            FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform].transform;// must be changed
                        }
                        colldingObjects[1].GetComponent<CardMain>().myObjectName = Convert.ToString(Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) + 1);
                        colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform - 1].SetActive(false); // must be changed
                        colldingObjects[1].GetComponent<CardMain>().enabled = false;
                        colldingObjects[0].GetComponent<CardMain>().transformations[0].SetActive(false); // must be changed
                        currentlyColliding[0] = "";
                        currentlyColliding[1] = "";
                        colldingObjects[0] = null;
                        colldingObjects[1] = null;
                        if (currentTransform > 1) FindObjectOfType<RayCaster>().CheckIfBBneed();
                        numCombineBreak++;
                        currentTransform++;
                        // }
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
            else
            {
                currentlyColliding[0] = "";
                currentlyColliding[1] = "";
                colldingObjects[0] = null;
                colldingObjects[1] = null;
            }
        }
        // END ====== First main card ========== END
        //===========================================
        //===========================================
        // ====== Second main card ========== 
        if ((colldingObjects[0].GetComponent<CardMain>().mainObjectNum == "1" && Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) >= 57 && Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) < 81) || (colldingObjects[1].GetComponent<CardMain>().mainObjectNum == "1" && Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) >= 57 && Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) < 81))
        {
            if (currentlyColliding[0] != "" && currentlyColliding[1] != "" && mainCard[1].GetComponent<CardMain>().transformations[numCombineBreak1 + 2].activeSelf == false)
            {
                if ((Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) % 2 != 0 && Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) % 2 == 0) || (Convert.ToInt64(colldingObjects[1].GetComponent<CardMain>().myObjectName) % 2 != 0 && Convert.ToInt64(colldingObjects[0].GetComponent<CardMain>().myObjectName) % 2 == 0))
                {
                    //numCombineBreak1++;
                    if (Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) == Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) + 1)
                    {
                        //Debug.LogWarning("first scenario");
                        //if (Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) != Convert.ToInt32(mainCard[1].GetComponent<CardMain>().myObjectName) + 1 && Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) >= Convert.ToInt32(mainCard[1].GetComponent<CardMain>().myObjectName) + 1)
                        //{

                        if (currentTransform1 > 2)
                        {
                            Debug.LogWarning("fir");
                            colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform1].transform.localScale = mainCard[1].GetComponent<CardMain>().transformations[currentTransform1 - 1].transform.localScale;
                            colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform1].transform.rotation = mainCard[1].GetComponent<CardMain>().transformations[currentTransform1 - 1].transform.rotation;
                        }
                        if (colldingObjects[0].GetComponent<CardMain>())
                            if (colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform1] != null)
                                colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform1].SetActive(true);
                        if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                        {
                            Debug.LogWarning("firaaaa");
                            FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform1].transform; // must be changed
                            FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform1].transform; // must be changed                        
                        }
                        colldingObjects[0].GetComponent<CardMain>().myObjectName = Convert.ToString(Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) + 1); // must be changed
                        colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform1 - 1].SetActive(false); // must be changed
                        colldingObjects[1].GetComponent<CardMain>().enabled = false;
                        colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false); // must be changed
                        currentlyColliding[0] = "";
                        currentlyColliding[1] = "";
                        colldingObjects[0] = null;
                        colldingObjects[1] = null;

                        if (currentTransform1 > 1) FindObjectOfType<RayCaster>().CheckIfBBneed();
                        numCombineBreak1++;
                        currentTransform1++;
                        //}
                    }
                    else if (Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) == Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) + 1)
                    {
                        Debug.LogWarning("second scenario" + colldingObjects[1].GetComponent<CardMain>().myObjectName + " << >>  " + Convert.ToInt32(mainCard[1].GetComponent<CardMain>().myObjectName) + 1);
                        // if (Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) >= Convert.ToInt32(mainCard[1].GetComponent<CardMain>().myObjectName) + 1 && Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) >= Convert.ToInt32(mainCard[1].GetComponent<CardMain>().myObjectName) + 1)
                        // {

                        if (currentTransform1 > 2)
                        {
                            Debug.LogWarning("sec");
                            colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform1].transform.localScale = mainCard[1].GetComponent<CardMain>().transformations[currentTransform1 - 1].transform.localScale;
                            colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform1].transform.rotation = mainCard[1].GetComponent<CardMain>().transformations[currentTransform1 - 1].transform.rotation;
                        }
                        if (colldingObjects[1].GetComponent<CardMain>())
                            if (colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform1] != null)
                                colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform1].SetActive(true); // must be changed
                        if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                        {
                            Debug.LogWarning("secaa");
                            FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform1].transform;// must be changed
                            FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform1].transform;// must be changed
                        }
                        CardMain tempCard0 = colldingObjects[0].GetComponent<CardMain>();
                        CardMain tempCard1 = colldingObjects[1].GetComponent<CardMain>();
                        tempCard1.GetComponent<CardMain>().myObjectName = Convert.ToString(Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) + 1);
                        tempCard1.GetComponent<CardMain>().transformations[currentTransform1 - 1].SetActive(false); // must be changed
                        tempCard1.GetComponent<CardMain>().enabled = false;
                        tempCard0.GetComponent<CardMain>().transformations[0].SetActive(false); // must be changed
                        currentlyColliding[0] = "";
                        currentlyColliding[1] = "";
                        colldingObjects[0] = null;
                        colldingObjects[1] = null;
                        if (currentTransform1 > 1) FindObjectOfType<RayCaster>().CheckIfBBneed();
                        numCombineBreak1++;
                        currentTransform1++;
                        // }
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
            else
            {
                currentlyColliding[0] = "";
                currentlyColliding[1] = "";
                colldingObjects[0] = null;
                colldingObjects[1] = null;
            }
        }
        // END ====== Second main card ========== END
        //===========================================
        //============ third main card ==============
        if ((colldingObjects[0].GetComponent<CardMain>().mainObjectNum == "2" && Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) >= 81) || (colldingObjects[1].GetComponent<CardMain>().mainObjectNum == "2" && Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) >= 81))
        {
            if (currentlyColliding[0] != "" && currentlyColliding[1] != "" && mainCard[1].GetComponent<CardMain>().transformations[numCombineBreak2 + 2].activeSelf == false)
            {
                if ((Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) % 2 != 0 && Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) % 2 == 0) || (Convert.ToInt64(colldingObjects[1].GetComponent<CardMain>().myObjectName) % 2 != 0 && Convert.ToInt64(colldingObjects[0].GetComponent<CardMain>().myObjectName) % 2 == 0))
                {
                    //numCombineBreak2++;
                    if (Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) == Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) + 1)
                    {
                        //Debug.LogWarning("first scenario");
                        //if (Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) != Convert.ToInt32(mainCard[1].GetComponent<CardMain>().myObjectName) + 1 && Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) >= Convert.ToInt32(mainCard[1].GetComponent<CardMain>().myObjectName) + 1)
                        //{

                        if (currentTransform2 > 2)
                        {
                            Debug.LogWarning("fir");
                            colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform2].transform.localScale = mainCard[1].GetComponent<CardMain>().transformations[currentTransform2 - 1].transform.localScale;
                            colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform2].transform.rotation = mainCard[1].GetComponent<CardMain>().transformations[currentTransform2 - 1].transform.rotation;
                        }
                        if (colldingObjects[0].GetComponent<CardMain>())
                            if (colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform2] != null)
                                colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform2].SetActive(true);
                        if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                        {
                            Debug.LogWarning("firaaaa");
                            FindObjectOfType<Rotater>().objToRotate = colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform2].transform; // must be changed
                            FindObjectOfType<RayCaster>().selectedObject = colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform2].transform; // must be changed                        
                        }
                        colldingObjects[0].GetComponent<CardMain>().myObjectName = Convert.ToString(Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) + 1); // must be changed
                        colldingObjects[0].GetComponent<CardMain>().transformations[currentTransform2 - 1].SetActive(false); // must be changed
                        colldingObjects[1].GetComponent<CardMain>().enabled = false;
                        colldingObjects[1].GetComponent<CardMain>().transformations[0].SetActive(false); // must be changed
                        currentlyColliding[0] = "";
                        currentlyColliding[1] = "";
                        colldingObjects[0] = null;
                        colldingObjects[1] = null;

                        if (currentTransform2 > 1) FindObjectOfType<RayCaster>().CheckIfBBneed();
                        numCombineBreak2++;
                        currentTransform2++;
                        //}
                    }
                    else if (Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) == Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) + 1)
                    {
                        Debug.LogWarning("second scenario" + colldingObjects[1].GetComponent<CardMain>().myObjectName + " << >>  " + Convert.ToInt32(mainCard[1].GetComponent<CardMain>().myObjectName) + 1);
                        // if (Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) >= Convert.ToInt32(mainCard[1].GetComponent<CardMain>().myObjectName) + 1 && Convert.ToInt32(colldingObjects[1].GetComponent<CardMain>().myObjectName) >= Convert.ToInt32(mainCard[1].GetComponent<CardMain>().myObjectName) + 1)
                        // {

                        if (currentTransform2 > 2)
                        {
                            Debug.LogWarning("sec");
                            colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform2].transform.localScale = mainCard[1].GetComponent<CardMain>().transformations[currentTransform2 - 1].transform.localScale;
                            colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform2].transform.rotation = mainCard[1].GetComponent<CardMain>().transformations[currentTransform2 - 1].transform.rotation;
                        }
                        if (colldingObjects[1].GetComponent<CardMain>())
                            if (colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform2] != null)
                                colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform2].SetActive(true); // must be changed
                        if (FindObjectOfType<RayCaster>().buttons.activeSelf == true) // must be changed  
                        {
                            Debug.LogWarning("secaa");
                            FindObjectOfType<Rotater>().objToRotate = colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform2].transform;// must be changed
                            FindObjectOfType<RayCaster>().selectedObject = colldingObjects[1].GetComponent<CardMain>().transformations[currentTransform2].transform;// must be changed
                        }
                        CardMain tempCard0 = colldingObjects[0].GetComponent<CardMain>();
                        CardMain tempCard1 = colldingObjects[1].GetComponent<CardMain>();
                        tempCard1.GetComponent<CardMain>().myObjectName = Convert.ToString(Convert.ToInt32(colldingObjects[0].GetComponent<CardMain>().myObjectName) + 1);
                        tempCard1.GetComponent<CardMain>().transformations[currentTransform2 - 1].SetActive(false); // must be changed
                        tempCard1.GetComponent<CardMain>().enabled = false;
                        tempCard0.GetComponent<CardMain>().transformations[0].SetActive(false); // must be changed
                        currentlyColliding[0] = "";
                        currentlyColliding[1] = "";
                        colldingObjects[0] = null;
                        colldingObjects[1] = null;
                        if (currentTransform2 > 1) FindObjectOfType<RayCaster>().CheckIfBBneed();
                        numCombineBreak2++;
                        currentTransform2++;
                        // }
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
            else
            {
                currentlyColliding[0] = "";
                currentlyColliding[1] = "";
                colldingObjects[0] = null;
                colldingObjects[1] = null;
            }
        }
        //============ end of third main card ===================
        // ======================================================
    }


    public void BreakIntoPieces()
    {
        Debug.LogWarning("Break into pieces");
        if (Convert.ToInt32(FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName) > 0)
        {
            Debug.LogWarning("process started");
            if (Convert.ToInt32(FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName) % 2 != 0)
            {
                Debug.LogWarning("its main");
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().mainObjectNum == "1")
                {
                    Debug.LogWarning("changed");
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[numCombineBreak1].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[numCombineBreak1 + 1].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[numCombineBreak1].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[numCombineBreak1 + 1].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[numCombineBreak1].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[numCombineBreak1 + 1].SetActive(false);
                    int newNameOfMC = Convert.ToInt32(FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName);
                    newNameOfMC -= 2;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = Convert.ToString(newNameOfMC);
                    currentlyBreaking[numCombineBreak1].GetComponent<CardMain>().transformations[0].SetActive(true);
                    currentlyBreaking[numCombineBreak1].GetComponent<CardMain>().enabled = true;
                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                    FindObjectOfType<RayCaster>().selectedObject = null;
                    FindObjectOfType<Rotater>().objToRotate = null;
                    FindObjectOfType<RayCaster>().buttons.SetActive(false);
                    numCombineBreak1--;
                    currentTransform1--;
                }
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().mainObjectNum == "0")
                {
                    Debug.LogWarning("changed");
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[numCombineBreak].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[numCombineBreak + 1].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[numCombineBreak].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[numCombineBreak + 1].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[numCombineBreak].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[numCombineBreak + 1].SetActive(false);
                    int newNameOfMC = Convert.ToInt32(FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName);
                    newNameOfMC -= 2;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = Convert.ToString(newNameOfMC);
                    currentlyBreaking[numCombineBreak].GetComponent<CardMain>().transformations[0].SetActive(true);
                    currentlyBreaking[numCombineBreak].GetComponent<CardMain>().enabled = true;
                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                    FindObjectOfType<RayCaster>().selectedObject = null;
                    FindObjectOfType<Rotater>().objToRotate = null;
                    FindObjectOfType<RayCaster>().buttons.SetActive(false);
                    numCombineBreak--;
                    currentTransform--;
                }
                if (FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().mainObjectNum == "2")
                {
                    Debug.LogWarning("changed");
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[numCombineBreak2].transform.rotation = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[numCombineBreak2 + 1].transform.rotation;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[numCombineBreak2].transform.localScale = FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[numCombineBreak2 + 1].transform.localScale;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[numCombineBreak2].SetActive(true);
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().transformations[numCombineBreak2 + 1].SetActive(false);
                    int newNameOfMC = Convert.ToInt32(FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName);
                    newNameOfMC -= 2;
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().myObjectName = Convert.ToString(newNameOfMC);
                    currentlyBreaking[numCombineBreak1].GetComponent<CardMain>().transformations[0].SetActive(true);
                    currentlyBreaking[numCombineBreak1].GetComponent<CardMain>().enabled = true;
                    FindObjectOfType<RayCaster>().CheckIfBBneed();
                    FindObjectOfType<RayCaster>().selectedObject.GetComponentInParent<CardMain>().chosen = false;
                    FindObjectOfType<RayCaster>().selectedObject = null;
                    FindObjectOfType<Rotater>().objToRotate = null;
                    FindObjectOfType<RayCaster>().buttons.SetActive(false);
                    numCombineBreak2--;
                    currentTransform2--;
                }
            }
        }
    }
}
