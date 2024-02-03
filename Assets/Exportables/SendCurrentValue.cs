using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SendCurrentValue : MonoBehaviour
{
    public Slider slider;
    public float SendSliderValue()
    {
        return slider.value;
    }
}
