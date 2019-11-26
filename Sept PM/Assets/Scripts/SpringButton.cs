using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringButton : MonoBehaviour
{
    public Light light;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "SpringButton")
        {
            light.enabled = !light.enabled;
            // false = true
            // true = false
        }
    }
}
