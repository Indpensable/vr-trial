using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FstSpnSrpt : MonoBehaviour
{
    [SerializeField] private List<Transform> spwnP;
    [SerializeField] private List<GameObject> spwnT;
    private int time = 3 ;
    // Update is called once per frame

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Init());
        }
    }
    public void Engage()
    {
        StartCoroutine(Eng());
    }
   
    IEnumerator Init()
    {
        yield return new WaitForSeconds(69);
        Engage();
    }
    IEnumerator Eng()
    {
        yield return new WaitForSeconds(time);
        Instantiate(spwnT[Random.Range(0, spwnT.Count)], spwnP[Random.Range(0, spwnP.Count)]);
        Engage();
    }
}
