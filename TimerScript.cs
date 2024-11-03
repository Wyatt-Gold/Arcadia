using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class NewEmptyCSharpScript : MonoBehaviour
{
    public TMP_Text displayTimeText;
    private static float currentTime = 300;
    private float displayTime;

    public UnityEvent gameOverEvent;
    void Update(){
        currentTime -= Time.deltaTime;
        displayTime = Mathf.Round(currentTime);
        if(((int)(displayTime/60)) > 1){
            displayTimeText.text = ((int)(displayTime/60)).ToString() + "min " +
            (displayTime%60).ToString() + "s";
        }
        else{
            displayTimeText.text = displayTime.ToString() + "s";
        }

        if(currentTime <= 0){
            Time.timeScale = 0;
            gameOverEvent.Invoke();
            displayTimeText.text = "GAME OVER";
        }
    }
}
