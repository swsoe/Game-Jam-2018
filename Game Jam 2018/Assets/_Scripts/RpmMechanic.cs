using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class RpmMechanic : MonoBehaviour {

    #region vars
    public MoveForward playArea;
    public Slider img_rpm;
    public Text txtCurrentGear;
    int currentGear = 1;
    [SerializeField] float currentRPM = 0;
    [SerializeField] float targetRPM;
    [SerializeField] Vector2 windowForShift;
    [SerializeField] float maxRPM;
    [SerializeField]float inciment = 2;
    [SerializeField] float baseSpeed = 2f;
    [SerializeField] float range = 10;



    #endregion


    // Use this for initialization
    void Awake () {
        
        if(playArea == null) {
            Debug.LogWarning("play area NOT ASSIGNED");
        }
        windowForShift.x = targetRPM - range;
        windowForShift.y = targetRPM + range;
        txtCurrentGear.text = "" + currentGear;

    }
	
	// Update is called once per frame
	void Update () {
        IncreaseRPM();
        CheckforInput();
        CheckForShift();
        img_rpm.value = calculateUI();
	}

    void CheckforInput() {

    }
    void IncreaseRPM() {
        currentRPM += Time.deltaTime * baseSpeed;
        
    }

    void CheckForShift() {
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
 

            if (currentRPM >= windowForShift.x && currentRPM <= windowForShift.y) {
                 currentRPM = targetRPM;
               // IncreaseTargetRPM();
                if (playArea != null) {
                    ShiftUp();
                }

            }
        }
        if (currentRPM >= maxRPM) {
            ResetShifter();
            Debug.Log("TODO: you didnt shift, consequences");
        }
    }
    void IncreaseTargetRPM() {
        targetRPM *= inciment;
        windowForShift.x = targetRPM - range;
        windowForShift.y = targetRPM + range;
    }
    public void ShiftUp() {

        playArea.speed += inciment;
        baseSpeed /= 1.5f;
        currentGear++;
        txtCurrentGear.text = "" + currentGear;
        ResetShifter();
    }
    float calculateUI() {
        return currentRPM / maxRPM;
    }

    
        
        
    
    private void ResetShifter() {
        currentRPM = 0;
    }
    
}

