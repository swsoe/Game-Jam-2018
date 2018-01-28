using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    [SerializeField]
    public float currentHealth;
    public float maxHealth;
    public Slider healthSlider;

    private void Awake() {
        healthSlider = GameObject.Find("HealthSlider").GetComponent<Slider>();
    }
    private void Start() {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int damage) {
        //Debug.Log(gameObject.name + " has taken " + damage + " points of damage");
        currentHealth -= damage;
        healthSlider.value = calculateUI();
        if (this.currentHealth <= 0 && this.gameObject.tag == "Player") {
            //Debug.Log("PlayerDies");
            currentHealth = maxHealth;
            healthSlider.value = calculateUI();
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

    float calculateUI() {
        Debug.Log("current: " + currentHealth + " max: " + maxHealth + " = " + currentHealth / maxHealth);
        return currentHealth / maxHealth;
       
    }

}
