using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    public Transform target;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.LookAt(target);

        // move him toward the target...
        // transform.translate....
    }
}
