using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TakeDamageOnHit : MonoBehaviour
{
    [SerializeField] private int MaxHealth;
    private int CurrentHealth;
    KillCount killCount;
    TakeDamageOnHitPlayer player;
    private bool firstHit = false;
    [SerializeField] private int dmg;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
        killCount = GameObject.Find("KCO").GetComponent<KillCount>();
        player = GameObject.Find("XR Origin").GetComponent<TakeDamageOnHitPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth == 0 )
        {
            killCount.AddKill();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            CurrentHealth -= 5;           
        }
        if (collision.gameObject.CompareTag("SafeZone"))
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            if(!firstHit == true)
            {
                player.DamageTake(dmg);
                firstHit = true;
            }

        }
    }
}
