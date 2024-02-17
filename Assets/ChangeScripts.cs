using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScripts : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Hand"))
        {
            GetComponent<SetHeight>().enabled = false;
            GetComponent<RotateGun>().enabled = false;
            this.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
