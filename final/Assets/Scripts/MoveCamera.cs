using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 CameraPosition;
    [Header("Camera Settings")]
    public float CameraSpeed = 3f;
    public float RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        CameraPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        // Rotate the camera based on the input
        transform.Rotate(Vector3.up, horizontalInput * RotationSpeed);
        if(Input.GetKey(KeyCode.W))
        {
            CameraPosition += transform.forward * CameraSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S))
        {
            CameraPosition -= transform.forward * CameraSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A))
        {
            CameraPosition.x -= transform.right.x * CameraSpeed * Time.deltaTime;
            CameraPosition.z -= transform.right.z * CameraSpeed * Time.deltaTime;
            //CameraPosition -= transform.right * CameraSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            CameraPosition.x += transform.right.x * CameraSpeed * Time.deltaTime;
            CameraPosition.z += transform.right.z * CameraSpeed * Time.deltaTime;
            //CameraPosition += transform.right * CameraSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            CameraPosition += Vector3.up * CameraSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            CameraPosition -= Vector3.up * CameraSpeed * Time.deltaTime;
        }
        this.transform.position = CameraPosition;
    }
}
