using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour {

    [SerializeField] int liveSize = 64;
    float width;
    public Image lifeBar;
	// Use this for initialization
	void Start () {
        var theBarRectTransform = lifeBar.transform as RectTransform;
        theBarRectTransform.sizeDelta = new Vector2(width, theBarRectTransform.sizeDelta.y);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton(KeyCode.KeypadEnter)) {
            UpdateDisplay();
        }
	}
    void UpdateDisplay() {
        lifeBar.rectTransform.sizeDelta.x -= liveSize;
    }
}
