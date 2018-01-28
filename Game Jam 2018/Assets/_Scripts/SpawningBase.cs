using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets._Scripts
{
    public abstract class SpawningBase : MonoBehaviour
    {
        public virtual IEnumerator Spawn()
        {
            Debug.Log("Error on base");
            return null;
        }
    }
}
