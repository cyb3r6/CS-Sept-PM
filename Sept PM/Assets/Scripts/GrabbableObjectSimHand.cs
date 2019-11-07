using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObjectSimHand : MonoBehaviour
{
    public SimHandMove simHandController;
    public bool isBeingHeld;

    void Update()
    {
        if(isBeingHeld == true)// && simHandController == null)
        {
            simHandController = GetComponentInParent<SimHandMove>();

            if (simHandController)
            {
                if (simHandController.clicked == false)// && isBeingHeld == true)
                {
                    Release();
                }
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        simHandController = collision.collider.GetComponent<SimHandMove>();
    }
    private void OnCollisionStay(Collision collision)
    {
        
        if (simHandController)
        {
            if(simHandController.clicked == true)
            {
                Grab();
            }
        }
    }

    void Grab()
    {
        isBeingHeld = true;
        this.transform.SetParent(simHandController.transform);
        this.GetComponent<Rigidbody>().isKinematic = true;
        this.GetComponent<Rigidbody>().useGravity = false;
        Debug.Log("Grab has been called");
    }
    void Release()
    {
        isBeingHeld = false;
        this.transform.SetParent(null);
        this.GetComponent<Rigidbody>().useGravity = true;
        this.GetComponent<Rigidbody>().isKinematic = false;
        Debug.Log("Release has been called");
    }
}
