using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static GameManager instance = null;              //Static instance of GameManager which allows it to be accessed by any other script.
    public PopulateGrid populateGrid;
    //Awake is always called before any Start functions
    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);



    }


    void Start()
    {
        GameObject contentList = GameObject.Find("Content");
        populateGrid = contentList.GetComponent<PopulateGrid>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int GetEntityIdByPolygonGameObject(GameObject obj)
    {
        foreach(PolygonEntity entity in populateGrid.GetPolygonEntityList()){
            if (entity.getGameObject().Equals(obj))
            {
                return entity.getID();

            }
        }
        return -1;
    }

    public GameObject GetGameObjectByEntityID(int id)
    {
        foreach (PolygonEntity entity in populateGrid.GetPolygonEntityList())
        {
            if (entity.getID() == (id))
            {
                return entity.getGameObject();
            }
        }
        return null;
    }



}
