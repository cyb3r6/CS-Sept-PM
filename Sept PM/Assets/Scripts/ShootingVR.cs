using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingVR : MonoBehaviour
{
    public GameObject pelletPrefab;
    public Transform spawnPoint;
    public float shootingMagnitude;
    public ShotCounter shotcounterScript;

    private GrababbleObject grabbableObject;
    private VRInput controller;

    void Start()
    {
        grabbableObject = this.GetComponent<GrababbleObject>();
    }

    void Update()
    {
        if(grabbableObject.isBeingHeld == true)
        {
            controller = grabbableObject.controller;

            if (controller)
            {
                if(controller.triggerValue > 0.8f)
                {
                    // temporary gameobject
                    GameObject temporary = Instantiate(pelletPrefab, spawnPoint.position, spawnPoint.rotation);
                    //temporary.GetComponent<Renderer>().material = ourPaints[paintIndex];
                    temporary.GetComponent<Rigidbody>().AddForce(temporary.transform.forward * shootingMagnitude);
                    shotcounterScript.shotsFired++;
                    Destroy(temporary, 3);
                }
            }
        }
    }
}
