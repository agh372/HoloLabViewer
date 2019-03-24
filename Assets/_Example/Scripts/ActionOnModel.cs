using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ActionOnModel : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler
{
    // Start is called before the first frame update
   public GameObject gameObject;
    public delegate void OnButtonClick(string name);
    public static event OnButtonClick onButtonClick;

    void Start()
    {
        
        if (gameObject.name.Equals("deletePrefab"))
        {

        }
        else
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        onButtonClick?.Invoke(gameObject.name);

    }
}
