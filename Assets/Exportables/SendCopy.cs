using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendCopy : MonoBehaviour
{
    [SerializeField] private Transform player;
    public Transform sendToMob()
    { 
        return player;
    }  
}
