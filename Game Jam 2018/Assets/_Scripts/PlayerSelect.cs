using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelect : MonoBehaviour {
    public GameObject[] selectedPlayer;
    
	// Use this for initialization
	void Awake () {

        GameObject go =  Instantiate(selectedPlayer[PlayerPrefs.GetInt("playerIndex")]) as GameObject;
        go.transform.parent = this.transform;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
