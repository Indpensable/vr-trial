using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    private GameObject temp;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Engage());
        }
    }
    IEnumerator Engage()
    {
        yield return new WaitForSeconds(69);
        temp = GameObject.Find("Script");
        temp.GetComponent<FstSpnSrpt>().enabled = true;

    }
}
