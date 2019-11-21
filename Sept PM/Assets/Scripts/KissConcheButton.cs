using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KissConcheButton : MonoBehaviour
{
    private Animator concheAnim;
    private bool enable = false;

    void Start()
    {
        concheAnim = GetComponent<Animator>();
    }

    public void ConchAnim()
    {
        enable = !enable;

        if (enable == true)
        {
            concheAnim.SetTrigger("Start");
        }
        else
        {
            concheAnim.SetTrigger("Stop");
        }
    }    
}
