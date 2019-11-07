using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public Animator brigeAnim;

    private void OnTriggerEnter(Collider other)
    {
        brigeAnim.SetTrigger("RaiseBridge");
    }
}
