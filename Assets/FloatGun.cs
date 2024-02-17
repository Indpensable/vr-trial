using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatGun : MonoBehaviour
{
    [SerializeField] private Transform lower;
    [SerializeField] private Transform upper;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().useGravity = false;
        gameObject.transform.position = lower.position;
        GoUp();
    }
    void GoUp()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, upper.transform.position, speed);
        //StartCoroutine(wait());
        //if (gameObject.transform.position == upper.position)
        //{
            //GoDown();
       // }
    }

    void GoDown()
    {
        gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, lower.transform.position, speed);
        StartCoroutine(wait());
        if (gameObject.transform.position == lower.position)
        { 
            GoUp();
        }
    }
    IEnumerator wait()
    {
        
        yield return new WaitForSeconds((upper.position.y-lower.position.y)/speed);
    }
}
