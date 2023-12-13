using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControl : MonoBehaviour
{
    public GameObject box;
    RaycastHit hit;
    

    //private GameObject heldObj; //object which we pick up
    

    //
    void Start()
    {
        
    }
    void Update()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(myRay, out hit))
        {
            if(Input.GetMouseButtonDown(0))
            {
                var selection = hit.transform;
                if(selection.CompareTag("Box"))
                {
                    Destroy(hit.transform.gameObject);
                }
            }
        }
        /*if (Input.GetMouseButtonDown(0))
        {   
            //perform raycast to check if player is looking at object within pickuprange
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Box"))
                {
                    Debug.Log("pickd");
                    Destroy(hit.transform.gameObject);
                }
            }
            
        }*/
    }
    
    
    
    
}
