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
    private GameObject cam;
    private float y;
    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponentInParent<Slider>();
        cam = GameObject.FindGameObjectWithTag("Cam");
        y = cam.transform.position.y;
    }

    private void Update()
    {
        UpdateText(slider.value);
        slider.onValueChanged.AddListener(UpdateText);
    }
    

    private void UpdateText(float value)
    {
        float val = slider.value;
        Vector3 scale = new Vector3 (val*1*y, val*1*y, val*1*y); 
        genericMob.transform.localScale= scale;
        scale = new Vector3(val * 1*y, val * 1*y, val * 1*y);
        fastMob.transform.localScale = scale;
        scale = new Vector3(val * 2*y, val * 2*y, val * 2*y);
        bigMob.transform.localScale = scale;

    }


}
