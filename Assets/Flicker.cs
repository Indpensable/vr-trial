using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Flick());
    }

    private IEnumerator Flick()
    {

        yield return new WaitForSeconds(Random.Range(0,3));
        GetComponent<Light>().enabled = false;
        yield return new WaitForSeconds(Random.Range(0, 3));
        GetComponent<Light>().enabled = true;
        StartCoroutine(Flick());

    }
}
