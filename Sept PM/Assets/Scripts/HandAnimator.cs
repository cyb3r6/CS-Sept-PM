using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandAnimator : MonoBehaviour
{
    private VRInput controller;
    private Animator handAnimator;
    private float triggerValue;
    
    void Start()
    {
        controller = GetComponent<VRInput>();
        handAnimator = GetComponentInChildren<Animator>();
    }
    void Update()
    {
        if (controller)
        {
            triggerValue = controller.triggerValue;
            if (handAnimator)
            {
                handAnimator.Play("FistClosing", 0, triggerValue);
            }
        }
    }
}
