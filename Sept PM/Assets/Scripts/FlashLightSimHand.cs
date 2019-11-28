using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightSimHand : MonoBehaviour
{
    private GrabbableObjectSimHand grabbableObjectSimHand;
    private SimHandMove simHandController;
    private Light flashLight;

    
    void Start()
    {
        grabbableObjectSimHand = GetComponent<GrabbableObjectSimHand>();
        flashLight = GetComponentInChildren<Light>();
    }

    
    void Update()
    {
        if (grabbableObjectSimHand.isBeingHeld == true)
        {
            simHandController = grabbableObjectSimHand.simHandController;

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                flashLight.enabled = !flashLight.enabled;
            }
        }
    }
}
