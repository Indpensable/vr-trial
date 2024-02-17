using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGun : MonoBehaviour
{
    [SerializeField] private Transform initPos;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = initPos.position;
        this.GetComponent<Rigidbody>().useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(1f, 1f, 1f);
    }
}
