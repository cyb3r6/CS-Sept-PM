using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedButtonnnnn : MonoBehaviour
{
    public Animator buttonAnim;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            buttonAnim.SetTrigger("Press");

            // do something creative!
            // turn on/off a light
            // turn on a video!

        }
    }
}
