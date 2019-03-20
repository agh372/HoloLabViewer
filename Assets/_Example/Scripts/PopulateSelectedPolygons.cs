using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulateSelectedPolygons : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Populate()
    {
        GameObject newObj;
        newObj = (GameObject)Instantiate(prefab, transform);
          //  newObj.GetComponent<Image>().color = Color.white;//UnityEngine.Random.ColorHSV();
        
    }
}
