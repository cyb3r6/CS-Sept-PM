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


    private void Update()
    {
        Debug.Log(this.transform.localEulerAngles.x);
    }
    private void OnTriggerStay(Collider other)
    {
        simHandController = other.GetComponent<SimHandMove>();

        if (simHandController)
        {
            if (simHandController.clicked == true)
            {
                Vector3 PositionToLookAt = new Vector3(transform.position.x, other.transform.position.y, other.transform.position.z);

                //PositionToLookAt.z = Mathf.Clamp(transform.position.z, minValue, maxValue);
                Debug.Log(PositionToLookAt);

                if(this.transform.localEulerAngles.x == maxValue)
                {
                    //transform.localEulerAngles.x = maxValue;

                    OnMax();
                }
                if(this.transform.localEulerAngles.x == minValue)
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
