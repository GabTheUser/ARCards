using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    int clickTimes;
    bool playAnim;
    public GameObject[] animControlMenus; // 0 main "animation menu"; 1 turn animations menu
    public void PlayAnimation1()
    {
        playAnim = !playAnim;
        if (playAnim==false)
        {
            GameObject animOwner = FindObjectOfType<RayCaster>().selectedObject.gameObject;
            animOwner.GetComponent<Animator>().SetBool("work", false);
           
        }
        else
        {
            GameObject animOwner = FindObjectOfType<RayCaster>().selectedObject.gameObject;
            animOwner.GetComponent<Animator>().SetBool("work", true);
            
        }      
    }

    public void OpenAnimMenus()
    {
        animControlMenus[0].SetActive(false);
        animControlMenus[1].SetActive(true);
    }

    public void CloseAnimMenus()
    {
        animControlMenus[1].SetActive(false);
        GameObject animOwner = FindObjectOfType<RayCaster>().selectedObject.gameObject;
        animOwner.GetComponent<Animator>().SetBool("work", false);
        animControlMenus[0].SetActive(true);
    }
}
