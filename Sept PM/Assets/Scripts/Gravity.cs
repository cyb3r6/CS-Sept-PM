using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public static List<GravitationObject> gravitationalObjects = new List<GravitationObject>();

    [Range(-10, 20)]
    public float graviationalForce = 1f;

    
    void FixedUpdate()
    {
        int loopCount = 1;

        foreach(GravitationObject objectGravity in gravitationalObjects)
        {
            for(int i = loopCount; i < gravitationalObjects.Count; i++)
            {
                Rigidbody objectGravityRigidbody = objectGravity.rigidBody;
                CalculateGravity(objectGravity, gravitationalObjects[i], objectGravityRigidbody, gravitationalObjects[i].rigidBody);
            }
            loopCount++;
        }
        AddGravitationForce();
    }

    void CalculateGravity(GravitationObject Object1, GravitationObject Object2, Rigidbody m1, Rigidbody m2)
    {
        Vector3 r = m1.position - m2.position;

        if(r == Vector3.zero)
        {
            return;
        }

        Vector3 force = r.normalized * (graviationalForce * m1.mass * m2.mass / Mathf.Pow(r.magnitude, 2));

        Object1.endforce -= force;
        Object2.endforce += force;
    }

    void AddGravitationForce()
    {
        foreach(GravitationObject tempObject in gravitationalObjects)
        {
            tempObject.AddEndForce();
        }
    }
}
