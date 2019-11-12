using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRInput : MonoBehaviour
{
    public bool isLeftHand;         // if isLeftHand is true, then the script is attached to the left hand
    public float triggerValue;
    public float gripValue;
    public Vector3 velocity;
    public Vector3 angularVelocity;

    private Vector3 previousPosition;
    private Vector3 previousAngularRotation;

    private string triggerAxis;
    private string gripAxis;

    
    
    void Start()
    {
        if(isLeftHand)      // short for isLeftHand == true
        {
            triggerAxis = "LeftTrigger";
            gripAxis = "LeftGrip";
        }
        else
        {
            triggerAxis = "RightTrigger";
            gripAxis = "RightGrip";
        }
    }

    
    void Update()
    {
        if(Input.GetAxis(triggerAxis) > 0f)
        {
            triggerValue = Input.GetAxis(triggerAxis);
            //Debug.Log("the trigger value is: " + triggerValue);
        }
        if(Input.GetAxis(gripAxis) > 0f)
        {
            gripValue = Input.GetAxis(gripAxis);
        }

        velocity = (this.transform.position - previousPosition) / Time.deltaTime;
        previousPosition = this.transform.position;

        angularVelocity = (this.transform.eulerAngles - previousAngularRotation) / Time.deltaTime;
        previousAngularRotation = this.transform.eulerAngles;
    }
}
