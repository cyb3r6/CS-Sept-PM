using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionSteps : MonoBehaviour
{
    public GameObject mainMenuCanvas;
    public GameObject intializeHeatCanvas;
    public GameObject saltWaterCanvas;
    public GameObject waterTemperatureCanvas;

    private List<GameObject> steps = new List<GameObject>();
    private int currentStep = 0;
    private GameObject currentCanvas;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnOnInitializingHeatCanvas()
    {
        intializeHeatCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);

        steps.Clear();
        for(int i = 0; i < intializeHeatCanvas.transform.childCount - 1; i++)
        {
            steps.Add(intializeHeatCanvas.transform.GetChild(i).gameObject);
            Debug.Log("Steps are: " + steps[i]);
        }
        currentCanvas = intializeHeatCanvas;
    }

    public void TurnOnSaltWaterCanvas()
    {
        saltWaterCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);

        steps.Clear();

        for (int i = 0; i < saltWaterCanvas.transform.childCount - 1; i++)
        {
            steps.Add(saltWaterCanvas.transform.GetChild(i).gameObject);
            Debug.Log("Steps are: " + steps[i]);
        }
        currentCanvas = saltWaterCanvas;

    }

    public void NextStep()
    {
        steps[currentStep].SetActive(false);
        Debug.Log("current Step is: " + currentStep);
        if(currentStep == steps.Count-1)
        {
            currentStep = 0;
            steps[0].SetActive(true);
            currentCanvas.SetActive(false);
            mainMenuCanvas.SetActive(true);

            return;
        }

        steps[++currentStep].SetActive(true);
    }

}
