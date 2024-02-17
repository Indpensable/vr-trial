using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class FireBulletonTrigger : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    [SerializeField] private float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(FireBullet);
    }

    private void FireBullet(ActivateEventArgs arg0)
    {
        GameObject spawnedObject = Instantiate(bullet);
        spawnedObject.transform.position = spawnPoint.position;
        spawnedObject.GetComponent<Rigidbody>().velocity = spawnPoint.forward*bulletSpeed;
        Destroy(spawnedObject, 5);
        if (bulletSpeed < 0f)
        {
            throw new NotImplementedException();
        }
    }
}
