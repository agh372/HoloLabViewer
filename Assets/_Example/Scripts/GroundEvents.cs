using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GroundEvents : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    LaserPointer laserPointer;

    void Start()
    {
        GameObject thePlayer = GameObject.Find("LaserPointer");
        laserPointer = thePlayer.GetComponent<LaserPointer>();
    }


    public void OnPointerEnter(PointerEventData eventData)
    {
        OnHoverEnter();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        OnHoverExit();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        OnClick();
    }

    void OnHoverEnter()
    {
    }

    void OnHoverExit()
    {
    }

    void OnClick()
    {
        
        GameObject handle = Resources.Load("models/pPlane2") as GameObject;
        handle.name = "loaded";
        GameObject handleGO = Instantiate(handle, laserPointer.getModelPlacementPosition(), Quaternion.identity);

    }

}