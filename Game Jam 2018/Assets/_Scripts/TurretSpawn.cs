using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurretSpawn : MonoBehaviour
{

    public GameObject[] enemies;
    public float spawnRate = 1.5f;

    // Use this for initialization
    void Start()
    {
        //IEnumerator spawnFunction = Spawn();
        //StartCoroutine(spawnFunction);
    }

    public void Spawn()
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            Instantiate(enemies[i], transform.position,  transform.localRotation);
        }

    }
}
