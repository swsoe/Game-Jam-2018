using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSystem : MonoBehaviour {
    public GameObject[] playerPrefab;
    [SerializeField] int selectedPlayer;


    public void Razer() {
        PlayerPrefs.SetInt("playerIndex", 0);

        SceneManager.LoadScene(0);
    }

    public void Galactica() {
        PlayerPrefs.SetInt("playerIndex", 1);

        SceneManager.LoadScene(0);
    }

    public void Spearhead() {
        PlayerPrefs.SetInt("playerIndex", 2);

        SceneManager.LoadScene(0);
    }
}

