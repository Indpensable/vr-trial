using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetHeight : MonoBehaviour
{
    [SerializeField] private float offset;
    // Start is called before the first frame update
    void Update()
    {
        GameObject cam = GameObject.FindGameObjectWithTag("Cam");
        float y = cam.transform.position.y - offset;
        gameObject.transform.position = new Vector3(gameObject.transform.position.x,y, gameObject.transform.position.z);
    }
    
}
