using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderScaling : MonoBehaviour
{
    public Slider slider;
    public float sliderFactor = 10f;
    public Vector3 maxScale = new Vector3(10f, 10f, 10f);
    public Vector3 minScale = new Vector3(1f, 1f, 1f);
    private float previousSliderValue;
    private Transform previousTransform;

    void Start()
    {
        previousTransform = this.transform;
        previousTransform.localScale = this.transform.localScale;
    }

    private void Update()
    {
        if (previousSliderValue < slider.value)
        {
            this.transform.localScale = new Vector3((this.transform.localScale.x) + (slider.value * sliderFactor), (this.transform.localScale.y) + (slider.value * sliderFactor), (this.transform.localScale.z) + (slider.value * sliderFactor));
        }
        if (previousSliderValue > slider.value)
        {
            this.transform.localScale = new Vector3((this.transform.localScale.x) - (slider.value * sliderFactor), (this.transform.localScale.y) - (slider.value * sliderFactor), (this.transform.localScale.z) - (slider.value * sliderFactor));
        }

        previousSliderValue = slider.value;

        if (slider.value == 0 || this.transform.localScale.x <= minScale.x)
        {
            this.transform.localScale = minScale;
        }
        if (slider.value == 1 || this.transform.localScale.x >= maxScale.x)
        {
            this.transform.localScale = maxScale;
        }
    }

}
