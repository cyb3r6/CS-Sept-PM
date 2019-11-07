using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject pelletPrefab;
    public Transform spawnPoint;
    public float shootingMagnitude;
    public ShotCounter shotcounterScript;

    private GrabbableObjectSimHand grabbableObjectSimHand;
    private SimHandMove simHandController;

    private void Start()
    {
        grabbableObjectSimHand = this.GetComponent<GrabbableObjectSimHand>();
    }
    void Update()
    {
        if(grabbableObjectSimHand.isBeingHeld == true)
        {
            simHandController = grabbableObjectSimHand.simHandController;

            if (Input.GetKeyDown(KeyCode.Mouse0))
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
