using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Vector3 CameraPosition;
    [Header("Movement")]
    public float moveSpeed;
    public float RotationSpeed;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        CameraPosition = this.transform.position;
        //rb.freezeRotation = true;

        //readyToJump = true;
    }

    private void Update()
    {
        // ground check
        //grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.3f, whatIsGround);

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        
        // Move the player
        //rb.AddForce(moveDirection * moveSpeed, ForceMode.Force);
        //MyInput();
        //transform.Rotate(Vector3.up, horizontalInput * RotationSpeed);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(orientation.forward * moveSpeed, ForceMode.Force);
            //CameraPosition += transform.right * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //CameraPosition -= transform.right * moveSpeed * Time.deltaTime;
            rb.AddForce(-orientation.forward * moveSpeed, ForceMode.Force);
        }
        /*if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Move the player left
            CameraPosition -= transform.right * moveSpeed * Time.deltaTime;
            //rb.AddForce(-orientation.right * moveSpeed, ForceMode.Force);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            // Move the player right
            CameraPosition += transform.right * moveSpeed * Time.deltaTime;
            //rb.AddForce(orientation.right * moveSpeed, ForceMode.Force);
        }*/
        //this.transform.position = CameraPosition;
        //SpeedControl();
        
        
    }



    /*private void MovePlayer()
    {
        // calculate movement direction
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;

        // on ground
        //if(grounded)
        if (Mathf.Abs(horizontalInput) > 0.1f || Mathf.Abs(verticalInput) > 0.1f)
        {
            rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);

        }

        // in air
        //else if(!grounded)
        //    rb.AddForce(moveDirection.normalized * moveSpeed * 10f * airMultiplier, ForceMode.Force);
    }*/

    
}
