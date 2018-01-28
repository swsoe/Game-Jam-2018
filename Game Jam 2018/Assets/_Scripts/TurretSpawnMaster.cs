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
        //Debug.Log("Spawning turrets");
        int i = r.Next(1, turrets.Count);
        foreach (GameObject T in turrets)
        {
            if (i <= 0)
                break;

            T.GetComponent<TurretSpawn>().Spawn();
            yield return new WaitForSeconds(0f);
            i--;
        }

    }
}

