
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZones : MonoBehaviour
{
    [SerializeField] GameObject safeZone;
    [SerializeField] List<Transform> zones;
    private int check = 0;
    private readonly int time = 50;

    private void Start()
    {
        StartCoroutine(SpawnSafeZones());
    }
    public void temp()
    {
        StartCoroutine(SpawnSafeZones());
    }

    IEnumerator SpawnSafeZones()
    {
        if (check == 0)
        {
            yield return new WaitForSeconds(time);
            check++;
        }
       
        yield return new WaitForSeconds(10);
        Instantiate(safeZone, zones[Random.Range(0 , zones.Count)]);
        yield return new WaitForSeconds(31);
        temp();
    }
}
