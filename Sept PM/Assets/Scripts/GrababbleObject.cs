using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrababbleObject : MonoBehaviour
{
    public VRInput controller;
    public bool isBeingHeld;
    public float forceMultiplier;
    void Update()
    {
        if(isBeingHeld == true)// && controller == null)
        {
            controller = GetComponentInParent<VRInput>();

            if (controller)
            {
                if (controller.gripValue < 0.8f)// && isBeingHeld == true)
                {
                    Release();
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        controller = collision.collider.GetComponent<VRInput>();
    }

    private void OnCollisionStay(Collision collision)
    {
        

        // if the controller exists and we've grabbed it from our colliding object
        if (controller)                 
        {
            if(controller.gripValue > 0.8f)
            {
                // do the grabbing!
                Grab();
            }
        }
    }

    void Grab()
    {
        this.transform.SetParent(controller.transform);
        this.GetComponent<Rigidbody>().isKinematic = true;
        this.GetComponent<Rigidbody>().useGravity = false;
        isBeingHeld = true;
    }
    void Release()
    {
        this.transform.SetParent(null);
        this.GetComponent<Rigidbody>().isKinematic = false;
        this.GetComponent<Rigidbody>().useGravity = true;
        this.GetComponent<Rigidbody>().velocity = controller.velocity  * forceMultiplier / this.GetComponent<Rigidbody>().mass;
        isBeingHeld = false;
    }
}
