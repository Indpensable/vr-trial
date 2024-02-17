using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMobSpawn : MonoBehaviour
{
    [SerializeField] private List<Transform> spawnPoints;
    [SerializeField] private GameObject genericMob;
    [SerializeField] private GameObject fastMob;
    [SerializeField] private GameObject BigBoi;
    private float time = 5;
    private int count = 0;
    // Start is called before the first frame update
    // Update is called once per frame
    void Start()
    {
        StartCoroutine(WaitIterate());
    }
    IEnumerator WaitIterate()
    {
        yield return new WaitForSeconds(time);
        spawnMob();
    }
    void spawnMob()
    {
        count = count + 1;
        if (count == 10)
        {
            Instantiate(BigBoi, spawnPoints[Random.Range(0, spawnPoints.Count)]);
            count = 0;
        }
        else if (count % 3 == 0 )
        {
            Instantiate(fastMob, spawnPoints[Random.Range(0, spawnPoints.Count)]);
        }
        else
        {
            Instantiate(genericMob, spawnPoints[Random.Range(0, spawnPoints.Count)]);
        }
        StartCoroutine(WaitIterate());
        

    }
}
