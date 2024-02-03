using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TakeDamageOnHit : MonoBehaviour
{
    [SerializeField] private int MaxHealth;
    private int CurrentHealth;
    KillCount killCount;
    
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
        killCount = GameObject.Find("KCO").GetComponent<KillCount>();
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            CurrentHealth -= 5;
            
        }
    }
}
