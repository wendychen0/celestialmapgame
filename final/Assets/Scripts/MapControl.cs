using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapControl : MonoBehaviour
{
    public RawImage map;
    public RawImage treasureMap;
    public GameObject telescopeObject;

    void Start()
    {
        
        map.enabled = false;
        treasureMap.enabled = false;
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Perform raycast to check if the object is clicked
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                
                if (hit.transform.gameObject == telescopeObject)
                {
                    // Toggle the visibility of the RawImage
                    ToggleVisibility();
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            map.enabled = true;
            treasureMap.enabled = false;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            map.enabled = false;
            treasureMap.enabled = true;
        }
    }

    // Toggle the visibility of the RawImage
    void ToggleVisibility()
    {
        if (map != null)
        {
            map.enabled = !map.enabled;
            Debug.Log("show map");
        }
    }
}
