using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitationObject : MonoBehaviour
{
    public Rigidbody rigidBody;     // sphere's rigidbody

    public Vector3 endforce;        // the force to apply in the update
    private Vector3 initialForce;   // the force to apply orbiting behaviour

    void Awake()
    {
        rigidBody = this.GetComponent<Rigidbody>();

        Gravity.gravitationalObjects.Add(this);
    }

    
    public void AddEndForce()
    {
        if(endforce != Vector3.zero)
        {
            rigidBody.AddForce(endforce);
            endforce = Vector3.zero;
        }
        
    }
}
