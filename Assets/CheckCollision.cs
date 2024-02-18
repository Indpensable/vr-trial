
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    private FstSpnSrpt fst;
    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("xxx"))
        {
            StartCoroutine(Engage());
        }
    }
    IEnumerator Engage()
    {
        yield return new WaitForSeconds(69);
        fst = GameObject.Find("Script").GetComponent<FstSpnSrpt>();
        fst.Engage();

    }
}
