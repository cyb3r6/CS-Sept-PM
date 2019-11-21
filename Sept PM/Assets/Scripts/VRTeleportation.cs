using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRTeleportation : MonoBehaviour
{
    [Tooltip("This is the transform we want to teleport")]
    public Transform vrRig;

    private VRInput controller;    
    private LineRenderer line;
    private bool shouldTeleport;
    private Vector3 hitPosition;

    
    void Start()
    {
        controller = GetComponent<VRInput>();
        line = this.GetComponent<LineRenderer>();
    }

    
    void Update()
    {
        if (controller)
        {
            if (controller.isThumbStickPressed)
            {
                RaycastHit hit;
                if (Physics.Raycast(controller.transform.position, controller.transform.forward, out hit))
                {
                    // DO THE THING 
                    hitPosition = hit.point;
                    line.SetPosition(0, controller.transform.position);
                    line.SetPosition(1, hitPosition);
                    line.enabled = true;

                    shouldTeleport = true;
                }
            }
            else if (controller.isThumbStickPressed == false)
            {
                if (shouldTeleport == true)
                {
                    vrRig.transform.position = hitPosition;
                    shouldTeleport = false;
                    line.enabled = false;
                }
            }
        }
    }
    
}
