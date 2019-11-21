using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimHandTeleportation : MonoBehaviour
{
    [Tooltip("This is the transform we want to teleport")]
    public Transform simHand;

    private SimHandMove simHandController;
    private LineRenderer line;
    private bool shouldTeleport;
    private Vector3 hitPosition;

        
    void Start()
    {
        simHandController = this.GetComponent<SimHandMove>();
        line = this.GetComponent<LineRenderer>();
    }

    
    void Update()
    {
        if (simHandController)
        {
            if (simHandController.isThumbStickPressed)
            {
                RaycastHit hit;
                if(Physics.Raycast(simHandController.transform.position, simHandController.transform.forward, out hit))
                {
                    // DO THE THING 
                    hitPosition = hit.point;
                    line.SetPosition(0, simHandController.transform.position);
                    line.SetPosition(1, hitPosition);
                    line.enabled = true;

                    shouldTeleport = true;
                }
            }
            else if(simHandController.isThumbStickPressed == false)
            {
                if(shouldTeleport == true)
                {
                    simHand.transform.position = hitPosition;
                    shouldTeleport = false;
                    line.enabled = false;
                }
            }
        }
    }
}
