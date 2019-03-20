using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateGrid : MonoBehaviour
{
    public GameObject prefab;
    public int numberToCreate;
    List<PolygonEntity> mPolygonEntityList ;
    // Start is called before the first frame update
    void Start()
    {
        mPolygonEntityList = new List<PolygonEntity>();
        Populate();
    }

    private void Populate()
    {
        GameObject newObj;
        for (int i = 0; i < numberToCreate; i++)
        {
            newObj = (GameObject)Instantiate(prefab, transform);
            newObj.GetComponent<Image>().color = Color.white;//UnityEngine.Random.ColorHSV();
            PolygonEntity entity = new PolygonEntity();
            entity.setID(i);
            entity.setGameObject(newObj);
            mPolygonEntityList.Add(entity);
        }
    }

    public List<PolygonEntity> GetPolygonEntityList()
    {
        return mPolygonEntityList;
    }
}
