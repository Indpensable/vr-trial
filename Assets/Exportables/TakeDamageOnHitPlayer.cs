using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TakeDamageOnHitPlayer : MonoBehaviour
{
    [SerializeField] private double MaxHealth;
    private double CurrentHealth;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(MaxHealth);
        CurrentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentHealth == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);           
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Mob"))
        {
            CurrentHealth -= 2.5;
            Debug.Log(CurrentHealth.ToString());
        }
    }
}
