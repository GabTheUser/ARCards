using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonTriggers : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public string buttonType;
    public void OnPointerDown(PointerEventData eventData)
    {
        if (buttonType == "u") FindObjectOfType<Rotater>().up = true;
        if (buttonType == "d") FindObjectOfType<Rotater>().down = true;
        if (buttonType == "l") FindObjectOfType<Rotater>().left = true;
        if (buttonType == "r") FindObjectOfType<Rotater>().right = true;
        if (buttonType == "+") FindObjectOfType<Rotater>().scaleUp = true;
        if (buttonType == "-") FindObjectOfType<Rotater>().scaleDown = true;        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (buttonType == "u") FindObjectOfType<Rotater>().up = false;
        if (buttonType == "d") FindObjectOfType<Rotater>().down = false;
        if (buttonType == "l") FindObjectOfType<Rotater>().left = false;
        if (buttonType == "r") FindObjectOfType<Rotater>().right = false;
        if (buttonType == "+") FindObjectOfType<Rotater>().scaleUp = false;
        if (buttonType == "-") FindObjectOfType<Rotater>().scaleDown = false;
    }

}
