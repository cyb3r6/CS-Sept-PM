using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnLeverMin : MonoBehaviour
{
    private Lever lever;
    public Material skyboxMaterial;

    private void OnTriggerEnter(Collider other)
    {
        lever = other.GetComponent<Lever>();
        if (lever)
        {
            // DO SOMETHING
            RenderSettings.skybox = skyboxMaterial;
        }
    }
}
