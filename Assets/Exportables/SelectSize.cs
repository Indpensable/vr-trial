using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectSize : MonoBehaviour
{
    [SerializeField] GameObject genericMob;
    [SerializeField] GameObject fastMob;
    [SerializeField] GameObject bigMob;
    [SerializeField] private Slider slider;
    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponentInParent<Slider>();  
    }
    private void Update()
    {
        UpdateText(slider.value);
        slider.onValueChanged.AddListener(UpdateText);
    }
    

    private void UpdateText(float value)
    {
        float val = slider.value;
        Vector3 scale = new Vector3 (val*0.25f, val*0.25f, val*0.25f); 
        genericMob.transform.localScale= scale;
        scale = new Vector3(val * 0.25f, val * 0.25f, val * 0.25f);
        fastMob.transform.localScale = scale;
        scale = new Vector3(val * 0.5f, val * 0.5f, val * 0.5f);
        bigMob.transform.localScale = scale;

    }


}
