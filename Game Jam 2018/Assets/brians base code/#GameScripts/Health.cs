using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    [SerializeField]
    public int currentHealth;
    public int maxHealth;

    private void Start() {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage) {
        //Debug.Log(gameObject.name + " has taken " + damage + " points of damage");
        currentHealth -= damage;
        if (this.currentHealth <= 0 && this.gameObject.tag == "Player") {
            //Debug.Log("PlayerDies");
            currentHealth = maxHealth;
            GameManager.Instance.CallPlayerDeath();
        }
        else if (this.currentHealth <= 0 && this.gameObject.tag != "Player") {
            currentHealth = 0;
            //Debug.Log("EnemyDies");
            EnemyDeath();
        }
    }

 

    public void EnemyDeath() {
        // Modify the points for each enemy based on health
       // if (this.tag != "Player") {
            currentHealth = 0;
            int pointsToGive = (int)(maxHealth * GameManager.Instance.pointModifier);
            GameManager.Instance.CallEarnedPoints(pointsToGive);
            Destroy(this.gameObject);
        
      //  }
    }    

  
  }
