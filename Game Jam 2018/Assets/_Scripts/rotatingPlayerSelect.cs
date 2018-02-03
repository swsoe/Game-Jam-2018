using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotatingPlayerSelect : MonoBehaviour {

    public Image[] ships;
    public Button selectedShip;
    int index = 0;
    int currentIndex;

    [SerializeField]MenuSystem menu;

	// Use this for initialization
	void Start () {
        currentIndex = index;
        menu = GetComponent<MenuSystem>();

	}
    private void Update() {
        UpdateDisplay(index);
    }

    // Update is called once per frame
    void UpdateDisplay (int index) {
        Debug.Log(index);
        selectedShip.image.sprite = ships[index].sprite;
	}
    public void Left() {
        if(index == 0) {
            index = ships.Length -1;
            
        }
        else {
            index--;
        }
        UpdateDisplay(index);
    }

    public void Right() {
        if (index == ships.Length -1) {
            index = 0;

        }
        else {
            index++;
        }
        UpdateDisplay(index);
    }

    public void selectOnClick() {
        if (index == 0) {
            menu.Razer();
        } else if (index == 1) {
            menu.Galactica();
        } else if (index == 2) {
            menu.Spearhead();
        }
    }
}
