using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectSize : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject enemy1;
    [SerializeField] private Slider slider;
    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponentInParent<Slider>();  
    }
    private void Start()
    {
        UpdateText(slider.value);
        slider.onValueChanged.AddListener(UpdateText);
    }
    

    private void UpdateText(float value)
    {
        float val = slider.value;
        Vector3 scale = new Vector3 (val*0.25f, val*0.25f, val*0.25f); 
        enemy.transform.localScale= scale;
        scale = new Vector3(val * 0.5f, val * 0.5f, val * 0.5f);
        enemy1.transform.localScale = scale;

    }


}
