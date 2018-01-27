using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WaveSpawner : MonoBehaviour, Assets._Scripts.SpawningBase
{

    public GameObject[] enemies;
    public float spawnRate = 1.5f;
    
	// Use this for initialization
	void Start ()
    {
        IEnumerator spawnFunction = Spawn();
        StartCoroutine(spawnFunction);
	}
	
	public IEnumerator Spawn ()
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            //Debug.Log("Spawning " + i.ToString());
            Instantiate(enemies[i], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(spawnRate);
        }
        
	}
}
