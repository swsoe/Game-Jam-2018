using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurretSpawnMaster : Assets._Scripts.SpawningBase
{
    System.Random r = new System.Random();
    List<GameObject> turrets;

    // Use this for initialization
    void Start()
    {
        turrets = new List<GameObject>(GameObject.FindGameObjectsWithTag("TurretSpawn"));
        //IEnumerator spawnFunction = Spawn();
        //StartCoroutine(spawnFunction);
    }

    public override IEnumerator Spawn()
    {
        foreach (GameObject T in turrets)
        {
            Debug.Log("Spawning turrets");
            T.GetComponent<TurretSpawn>().Spawn();
            yield return new WaitForSeconds(1f);
        }

    }
}

