using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapAppear : MonoBehaviour
{
    public GameObject map;
    public float appearanceDistance = 5f;
    public KeyCode appearanceKey = KeyCode.P;

    void Start()
    {
        // Hide the object at the start
        if (map != null)
        {
            map.SetActive(false);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(appearanceKey))
        {
            Debug.Log("map");
            AppearObject();
        }
    }

    void AppearObject()
    {
        // Get the camera's position and forward direction
        //Vector3 cameraPosition = Camera.main.transform.position;
        //Vector3 cameraForward = Camera.main.transform.forward;

        // Calculate the position for the object to appear
        //Vector3 objectPosition = cameraPosition + cameraForward * appearanceDistance;

        map.SetActive(true);
        //map.transform.position = objectPosition;
        // Instantiate the object at the calculated position
        //GameObject newObject = Instantiate(map, objectPosition, Quaternion.identity);
    }
}
