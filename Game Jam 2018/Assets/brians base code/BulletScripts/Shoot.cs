using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    public GameObject bulletPrefab;
    public float shootDelay = .5f;
    public bool shooting = false;

    void Update()
    {
        if (!shooting && Input.GetButton("Fire1") && this.gameObject.activeSelf)
        {
            shooting = true;
            InvokeRepeating("ShootForward", shootDelay, shootDelay);
        }
        else if (shooting && (!Input.GetButton("Fire1") || !this.gameObject.activeSelf))
        {
            shooting = false;
            CancelInvoke();
        }
    }

    void  ShootForward()
    {
        PoolingManager.InstantiatePooled(bulletPrefab, transform.position, transform.rotation);
    }
}
