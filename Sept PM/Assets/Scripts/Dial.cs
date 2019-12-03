using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dial : MonoBehaviour
{
    public float outAngle;
    public float startAngle = 0.0f;
    public float minAngle;
    public float maxAngle;


    private Quaternion startRotation = Quaternion.identity;
    private SimHandMove simHandController;
    private Vector3 lastHandPosition;       // recording the last hand position relative to the dial
    private Vector3 currentEulerAngle;
    private Vector3 fromDialToHand;

    


    void Start()
    {
        //outAngle = Mathf.Clamp(startAngle, minAngle, maxAngle);
    }


    void Update()
    {
        if (simHandController)
        {
            if (simHandController.clicked)
            {
                CalculateToHand();
                CalculateAngle();
                this.transform.localRotation = startRotation * Quaternion.AngleAxis(outAngle, Vector3.forward);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        simHandController = other.GetComponent<SimHandMove>();

        if (simHandController)
        {
            CalculateToHand();

            lastHandPosition = fromDialToHand;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
        if (simHandController)
        {
            lastHandPosition = fromDialToHand;

            
        }
        //simHandController = null;
    }

    Vector3 CalculateToHand()
    {
        Vector3 position = this.transform.position;
        Vector3 toTransform = (simHandController.transform.position - position);
        toTransform.Normalize();

        fromDialToHand = toTransform;

        return fromDialToHand;
        
    }

    

    void CalculateAngle()
    {
        Vector3 toHand = CalculateToHand();     // return the vector3 from the dial to the hand

        outAngle = Vector3.SignedAngle(lastHandPosition, toHand, Vector3.forward);

        if(outAngle <= minAngle)
        {
            outAngle = minAngle;
        }
        if(outAngle >= maxAngle)
        {
            outAngle = maxAngle;
        }
    }
}