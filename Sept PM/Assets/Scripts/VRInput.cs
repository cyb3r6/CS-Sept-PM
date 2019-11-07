using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRInput : MonoBehaviour
{
    public bool isLeftHand;         // if isLeftHand is true, then the script is attached to the left hand
    public float triggerValue;
    public float gripValue;

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
    }
}
