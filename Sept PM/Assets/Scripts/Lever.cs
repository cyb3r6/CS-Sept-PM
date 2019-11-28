using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    private SimHandMove simHandController;

    public float minValue;
    public float maxValue;
    public Material skyboxMaterial1;
    public Material skyboxMaterial2;

    private void OnTriggerStay(Collider other)
    {
        simHandController = other.GetComponent<SimHandMove>();

        if (simHandController)
        {
            if (simHandController.clicked == true)
            {
                Vector3 PositionToLookAt = new Vector3(transform.position.x, other.transform.position.y, other.transform.position.z);

                PositionToLookAt.y = Mathf.Clamp(transform.position.y, minValue, maxValue);

                if(PositionToLookAt.y == maxValue)
                {
                    OnMax();
                }
                if(PositionToLookAt.y == minValue)
                {
                    OnMin();
                }

                this.transform.LookAt(PositionToLookAt);
            }
        }
    }

    void OnMax()
    {
        RenderSettings.skybox = skyboxMaterial2;
    }

    void OnMin()
    {
        RenderSettings.skybox = skyboxMaterial1;
    }
}
