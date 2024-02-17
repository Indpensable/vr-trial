using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCount : MonoBehaviour
{

    public Text killCount;
    int kills;
    // Start is called before the first frame update
    void Start()
    {
        kills = 0;
    }
    private void showKills()
    {
        killCount.text = kills.ToString();
    }

    public void AddKill()
    {
        kills++;
        if(kills == 100)
        {

        }
    }
    // Update is called once per frame
    void Update()
    {
        showKills();
    }
}
