using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paintball : MonoBehaviour
{
    public List<Material> ourPaints = new List<Material>();
    private Material paintMaterial;
    private int listSize;
    static private int paintIndex = 0;

    void Start()
    {
        paintMaterial = GetComponent<Renderer>().material;
        Debug.Log("paint Material: " + paintMaterial);
        listSize = ourPaints.Count;
    }
       
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Paintable")
        {
            collision.collider.GetComponent<Renderer>().material = ourPaints[paintIndex];
            paintIndex = Random.Range(0, listSize);
        }
    }
}
