using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolygonEntity 
{
   private int polygonId;
    private GameObject polygon;

    public int getID()
    {
        return polygonId;
    }

    public void setID(int id)
    {
        polygonId = id;
    }

    public GameObject getGameObject()
    {
        return polygon;
    }

    public void setGameObject(GameObject obj)
    {
        polygon = obj;
    }
}
