using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLocamotion : MonoBehaviour
{
    public Transform vrRig;
    public Transform director;

    private VRInput controller;
    private Vector3 PlayerForward;
    private Vector3 PlayerRight;
    
    void Start()
    {
        controller = GetComponent<VRInput>();
    }

    
    void Update()
    {
        PlayerForward = director.forward;
        PlayerForward.y = 0f;
        PlayerForward.Normalize();

        PlayerRight = director.right;
        PlayerRight.y = 0f;
        PlayerRight.Normalize();

        vrRig.Translate(PlayerForward * controller.Thumbstick.y * Time.deltaTime);
        vrRig.Translate(PlayerRight * controller.Thumbstick.x * Time.deltaTime);

    }
}
