using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SliderColor : MonoBehaviour
{
    public Slider slider;
    public Image fillImage;
    public Color ValueColor = Color.green;

    void Start()
    {
        slider.onValueChanged.AddListener(OnSliderValueChanged);
        OnSliderValueChanged(slider.value);
    }
    void OnSliderValueChanged(float value)
    {
        float healthPercentage = value / slider.maxValue;
        
        if (healthPercentage > 0.5)
        {
            fillImage.color = Color.green;
        }
        else if (healthPercentage > 0.2 && healthPercentage <= 0.5) 
        { 
            fillImage.color = Color.yellow;
        }
        else
        {
            fillImage.color = Color.red;
        }
    }

}
