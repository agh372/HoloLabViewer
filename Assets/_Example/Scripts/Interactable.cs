using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interactable : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler,IPointerDownHandler
{
    public enum InteractionState
    {
        NotSelected,
        Selected,
        Translate
    };

    private InteractionState state;
    private GameObject deleteMain;
    private GameObject translateMain;
    private IEnumerator coroutine;


    void Start()
    {
        state = InteractionState.NotSelected;
    }

    private void OnEnable()
    {
        ActionOnModel.onButtonClick += DeleteItem;
       ActionOnModel.onButtonClick += Translate;
    }

    private void Translate(string name)
    {
        Debug.Log(name);
        if (name.Equals("translate(Clone)"))
        {
            coroutine = Translate(1.0f);
            StartCoroutine(coroutine);
        }

    }

    private IEnumerator Translate(float v)
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
        }
    }

    private void DeleteItem(String name)
    {
        Debug.Log(name);

        if (name.Equals("delete(Clone)"))
        {
            Destroy(gameObject);
            StopCoroutine(coroutine);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {

      

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        state = InteractionState.Selected;

        GameObject translate = Resources.Load("translatePrefab") as GameObject;
        translate.name = "translate";
        GameObject delete = Resources.Load("deletePrefab") as GameObject;
        delete.name = "delete";

        Vector3 pos = new Vector3(0f, 2.5f, 0f);
        Vector3 pos2 = new Vector3(0f, 2.5f, 1f);

        //   Instantiate(boulder, boulderindicate.position + pos, boulderindicate.rotation);
        GameObject translateGO = Instantiate(translate, this.gameObject.transform.position + pos, Quaternion.identity);
        GameObject deleteGO = Instantiate(delete, this.gameObject.transform.position + pos2, Quaternion.identity);

        translateGO.transform.parent = this.transform;
        deleteGO.transform.parent = this.transform;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
       // throw new System.NotImplementedException();
    }

    public void Pressed()
    {
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        bool flip = !renderer.enabled;

        renderer.enabled = flip;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
