using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WaveSpawner : Assets._Scripts.SpawningBase
{

    public GameObject[] enemies;
    public float spawnRate = 1.5f;
    
	// Use this for initialization
	void Start ()
    {
        //IEnumerator spawnFunction = Spawn();
        //StartCoroutine(spawnFunction);
	}
	
	public override IEnumerator Spawn ()
    {
        //Debug.Log("Spawning Wave");
        for (int i = 0; i < enemies.Length; i++)
        {
            //Debug.Log("Spawning " + i.ToString());
            Instantiate(enemies[i], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnRate);
        }
        
	}
}
