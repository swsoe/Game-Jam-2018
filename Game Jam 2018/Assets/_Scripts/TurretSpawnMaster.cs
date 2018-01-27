using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurretSpawnMaster : MonoBehaviour, Assets._Scripts.SpawningBase
{

    List<GameObject> turrets;

    // Use this for initialization
    void Start()
    {
        turrets = new List<GameObject>(GameObject.FindGameObjectsWithTag("TurretSpawn"));
        IEnumerator spawnFunction = Spawn();
        StartCoroutine(spawnFunction);
    }

    public IEnumerator Spawn()
    {
        foreach (GameObject T in turrets)
        {
            T.GetComponent<TurretSpawn>().Spawn();
            yield return new WaitForSeconds(0f);
        }

    }
}

