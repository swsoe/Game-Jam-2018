using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets._Scripts
{

    public class SpawnerMaster : MonoBehaviour
    {

        public float spawnRate = 10f;
        List<GameObject> enemySpawners;
        System.Random r = new System.Random();

        // Use this for initialization
        void Start()
        {
            enemySpawners = new List<GameObject>(GameObject.FindGameObjectsWithTag("Spawners"));
            InvokeRepeating("SpawnSomeEnemies", 0f, 10f);
        }

        // Update is called once per frame
        void Update()
        {

        }

        void SpawnSomeEnemies()
        {
            int level =  r.Next(1, enemySpawners.Count);
            //Debug.Log("Spawning " + level + " enemies");
            for (int i = 0; i < level; i++)
            {
                //Debug.Log("Spawning in");
                SpawningBase x = enemySpawners[i].GetComponent<SpawningBase>();
                if (x == null)
                    Debug.Log("Error");
                IEnumerator e = x.Spawn();
                StartCoroutine(e);

            }
        }
    }
}
