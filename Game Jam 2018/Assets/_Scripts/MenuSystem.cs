using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSystem : MonoBehaviour {
    public GameObject[] playerPrefab;
    [SerializeField] int selectedPlayer;

    private void Awake() {
        clearprefs();
    }

    public void Razer() {
        PlayerPrefs.SetInt("playerIndex", 0);
        Debug.Log(PlayerPrefs.GetInt("playerIndex"));
        SceneManager.LoadScene(0);
    }

    public void Galactica() {
        PlayerPrefs.SetInt("playerIndex", 1);
        Debug.Log(PlayerPrefs.GetInt("playerIndex"));
        SceneManager.LoadScene(0);
    }

    public void Spearhead() {
        PlayerPrefs.SetInt("playerIndex", 2);
        Debug.Log(PlayerPrefs.GetInt("playerIndex"));
        SceneManager.LoadScene(0);
    }
    void clearprefs() {
        PlayerPrefs.DeleteAll();
    }
}

