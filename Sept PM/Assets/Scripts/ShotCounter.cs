using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotCounter : MonoBehaviour
{
    public Text descriptionText;
    public int shotsFired;

    
    void Update()
    {
        descriptionText.text = "Shots Fired: " + shotsFired;
    }
}
