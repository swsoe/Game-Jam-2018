using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RpmMechanic : MonoBehaviour {

    #region vars
    public MoveForward playArea;
    public Slider img_rpm;


    [SerializeField] float currentRPM = 0;
    [SerializeField] float targetRPM;
    [SerializeField] float maxRPM;
    [SerializeField]float inciment = 2;
    [SerializeField] float baseSpeed = 2f;



    #endregion
    // Use this for initialization
    void Awake () {
        
        if(playArea == null) {
            Debug.LogWarning("play area NOT ASSIGNED");
        }
       
	}
	
	// Update is called once per frame
	void Update () {
        IncreaseRPM();
        CheckForShift();
        img_rpm.value = calculateUI();
	}

    void IncreaseRPM() {
        currentRPM += Time.deltaTime * baseSpeed;
    }

    void CheckForShift() {
        if (currentRPM >= targetRPM) {
            currentRPM = targetRPM;
            IncreaseTargetRPM();
            if(playArea != null) {
                ShiftUp();
            }
            
        } 
        if(currentRPM >= maxRPM) {
            Debug.Log("max speed, you explode");
        }
        
    }
    void IncreaseTargetRPM() {
        targetRPM *= inciment;
        
    }
    public void ShiftUp() {
        Debug.Log("we shifted");
        playArea.speed += inciment;
    }
    float calculateUI() {
        return currentRPM / maxRPM;
    }
}

