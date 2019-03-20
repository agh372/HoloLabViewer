
 using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class OnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{

    private Image image;
    PopulateSelectedPolygons populateSelectedPolygonsList;
    void Start()
    {
        image = GetComponent<Image>();
        GameObject thePlayer = GameObject.Find("SelectedContent");
        populateSelectedPolygonsList = thePlayer.GetComponent<PopulateSelectedPolygons>();
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
   //     image.color = Color.gray;
    }

    void OnHoverExit()
    {
       // image.color = Color.white;
    }

    void OnClick()
    {
        if(image.color == Color.blue)
        image.color = Color.white;
        else
         image.color = Color.blue;

        Debug.Log(GameManager.instance.GetEntityIdByPolygonGameObject(image.gameObject));
        populateSelectedPolygonsList.Populate();

    }

}