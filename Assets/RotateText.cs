using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotateText : MonoBehaviour
{ 
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0.5f, 0);
    }
}
