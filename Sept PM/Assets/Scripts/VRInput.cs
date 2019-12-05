using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRInput : MonoBehaviour
{
    public bool isLeftHand;         // if isLeftHand is true, then the script is attached to the left hand
    public float triggerValue;
    public float gripValue;
    public bool isThumbStickPressed;
    
    public Vector3 velocity;
    public Vector3 angularVelocity;
    public Vector2 Thumbstick;

    private Vector3 previousPosition;
    private Vector3 previousAngularRotation;

    private float thumbstickXValue;
    private float thumbstickYValue;

    private string triggerAxis;
    private string gripAxis;
    private string thumbstickButton;
    private string thumbstickX;
    private string thumbstickY;
    
    void Start()
    {
        if(isLeftHand)      // short for isLeftHand == true
        {
            triggerAxis = "LeftTrigger";
            gripAxis = "LeftGrip";
            thumbstickButton = "LeftThumbstickButton";
            thumbstickX = "LeftThumbstickX";
            thumbstickY = "LeftThumbstickY";
        }
        else
        {
            triggerAxis = "RightTrigger";
            gripAxis = "RightGrip";
            thumbstickButton = "RightThumbstickButton";
            thumbstickX = "RightThumbstickX";
            thumbstickY = "RightThumbstickY";
        }
    }

    
    void Update()
    {
        triggerValue = Input.GetAxis(triggerAxis);        
        gripValue = Input.GetAxis(gripAxis);
        thumbstickXValue = Input.GetAxis(thumbstickX);
        thumbstickYValue = Input.GetAxis(thumbstickY);

        Thumbstick = new Vector2(thumbstickXValue, thumbstickYValue);

        if (Input.GetButtonDown(thumbstickButton))
        {
            isThumbStickPressed = true;
        }
        if (Input.GetButtonUp(thumbstickButton))
        {
            isThumbStickPressed = false;
        }


        velocity = (this.transform.position - previousPosition) / Time.deltaTime;
        previousPosition = this.transform.position;

        angularVelocity = (this.transform.eulerAngles - previousAngularRotation) / Time.deltaTime;
        previousAngularRotation = this.transform.eulerAngles;
    }
}
