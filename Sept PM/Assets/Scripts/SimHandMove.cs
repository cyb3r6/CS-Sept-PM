using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimHandMove : MonoBehaviour
{
    // Global space
    public float moveSpeed = 3.0f;
    public float turnSpeed = 15.0f;
    public bool clicked = false;
    private void Start()
    {
        // Start() local space
        //Cursor.lockState = CursorLockMode.Locked;
        
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            clicked = true;
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            clicked = false;
        }

        #region movement
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        }

        // move up and down
        if (Input.GetKey(KeyCode.LeftShift))
        {
            this.transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            this.transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);
        }
        #endregion

        #region Rotate using Keyboard

        // rotate
        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Rotate(Vector3.down * Time.deltaTime * turnSpeed, Space.World);   // rotate left
        }

        if (Input.GetKey(KeyCode.F))
        {
            this.transform.Rotate(Vector3.right * Time.deltaTime * turnSpeed, Space.World);  // rotate forward
        }

        if (Input.GetKey(KeyCode.R))
        {
            this.transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed, Space.World);     // rotate right
        }
        if (Input.GetKey(KeyCode.E))
        {
            this.transform.Rotate(Vector3.left * Time.deltaTime * turnSpeed,Space.World);      // rotate up
        }
        
        #endregion

        #region Rotate using Mouse
        /*
        this.transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * turnSpeed, Space.World);
        this.transform.Rotate(Vector3.left * Input.GetAxis("Mouse Y") * turnSpeed, Space.World);
        */
        #endregion
    }

    public void Bob()
    {
        // our custom function/method
        Debug.Log("Bob has been called");
    }

}






