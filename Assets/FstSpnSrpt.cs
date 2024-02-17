using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FstSpnSrpt : MonoBehaviour
{
    [SerializeField] private List<Transform> spwnP;
    [SerializeField] private List<GameObject> spwnT;
    private int check = 0 ;
    // Update is called once per frame
    void Update()
    {
        check++;
        if (check == 20)
        {
            Instantiate(spwnT[Random.Range(0,spwnT.Count)], spwnP[Random.Range(0, spwnP.Count)]);   
            check = 0 ;
        }
    }
}
