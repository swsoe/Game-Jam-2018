using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSystem : MonoBehaviour {
    public GameObject[] playerPrefab;
    [SerializeField] int selectedPlayer;

    List<GameObject> menuItems;
    List<GameObject> aboutItems;

    void Start()
    {
        menuItems = new List<GameObject>(GameObject.FindGameObjectsWithTag("MenuItems"));
        aboutItems = new List<GameObject>(GameObject.FindGameObjectsWithTag("AboutItems"));

        foreach (GameObject go in aboutItems)
            go.SetActive(false);
    }

    public void Razer() {
        PlayerPrefs.SetInt("playerIndex", 0);

        SceneManager.LoadScene(1);
    }

    public void Galactica() {
        PlayerPrefs.SetInt("playerIndex", 1);

        SceneManager.LoadScene(1);
    }

    public void Spearhead() {
        PlayerPrefs.SetInt("playerIndex", 2);

        SceneManager.LoadScene(1);
    }

    public void AboutButton()
    {
        foreach (GameObject go in menuItems)
            go.SetActive(false);
        foreach (GameObject go in aboutItems)
            go.SetActive(true);
    }

    public void AboutBackButton()
    {
        foreach (GameObject go in menuItems)
            go.SetActive(true);
        foreach (GameObject go in aboutItems)
            go.SetActive(false);
    }
}

