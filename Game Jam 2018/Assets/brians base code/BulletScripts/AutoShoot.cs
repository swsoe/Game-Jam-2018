using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float shootDelay = .5f;


    private void OnDisable()
    {
        CancelInvoke();
    }
    private void OnEnable()
    {
        InvokeRepeating("ShootForward", shootDelay, shootDelay);
    }

    void ShootForward()
    {
        PoolingManager.InstantiatePooled(bulletPrefab, transform.position, transform.rotation);
    }
}
