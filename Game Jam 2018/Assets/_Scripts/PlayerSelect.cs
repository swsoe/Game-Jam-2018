using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour {
    public GameObject[] selectedPlayer;
    PlayerMovement playerMovement;
    MoveForward gameplayMoveScript;
    
	// Use this for initialization
	void Awake () {
        gameplayMoveScript = GameObject.Find("GamePlayArea").GetComponent<MoveForward>();
        GameObject go =  Instantiate(selectedPlayer[PlayerPrefs.GetInt("playerIndex")]) as GameObject;
        go.transform.parent = this.transform;
        playerMovement = go.GetComponent<PlayerMovement>();
        gameplayMoveScript.speed = playerMovement.startingSpeed;
	}

}
