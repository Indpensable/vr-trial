using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            Debug.Log("]");
            audioSource.Play();
        }
    }
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("]");
            audioSource.Play();
        }
            
    }
}
