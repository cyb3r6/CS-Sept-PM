using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    public Transform target;
    public float moveSpeed;
    public float stoppingDistance;

    void Update()
    {
        transform.LookAt(target);

        // move him toward the target...
        // transform.translate....
        if (Vector3.Distance(transform.position, target.position) > stoppingDistance)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        }
        
    }
}
