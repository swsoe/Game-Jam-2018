using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour {

    public int currentLives;
    [SerializeField] int maxLives = 3;
    public Text livesRemaining;

    private void OnEnable() {
        GameManager.PlayerDeath += PlayerDies;

    }
    private void OnDisable() {
        GameManager.PlayerDeath -= PlayerDies;
    }
    // Use this for initialization
    void Start () {
        currentLives = maxLives;
        UpdateDisplay();
    }
	
	// Update is called once per frame
	void Update () {
  
	}
   

    void GameOver() {
       
        Debug.Log("gameover");
    }

    void UpdateDisplay() {
        if(currentLives >= 0) {
            livesRemaining.text = "Lives: " + currentLives;
        }
        
    }
    public void PlayerDies() {
        //play death animation and sound effects
        currentLives--;
        
        UpdateDisplay();
        if (currentLives <= 0) {
            GameOver();
        }
        if (this.gameObject.tag == "Player") {

            this.gameObject.SetActive(false);
            return;
        }
    }

}
