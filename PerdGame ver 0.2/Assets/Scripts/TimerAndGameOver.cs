using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//Bron: https://www.youtube.com/watch?v=qe8MCWsGthM
//Kanaal: Learn Everything Fast
public class TimerAndGameOver : MonoBehaviour
{
    public int countDownStartValue = 60;
    public Text timerUI;
    public Text FinalScoreText;


    // Start is called before the first frame update
    void Start()
    {
       countDownTimer(); 
    }

    void countDownTimer()
    {
        if (countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue); 
            timerUI.text = "Timer : " + spanTime.Minutes + " : " + spanTime.Seconds;
            //Debug.Log("Timer: " + countDownStartValue);
            //timer wordt met 1 verlaagt.
            countDownStartValue--;
            //Na 1 seconde wordt de functie opnieuw aangeroepen. 
            Invoke("countDownTimer", 1.0f);
        }else
        {
            //Debug.Log("UNHIDE!");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
           //cameraScript cursor = GameObject.Find("Main Camera").GetComponent<cameraScript>();
            //cursor.lockCursor = false;
            //zet het spel stil
            Time.timeScale = 0;
            //haalt de huidige score op uit het mainCharacter object
            player_movement highScore = GameObject.Find("Player").GetComponent<player_movement>();
            timerUI.text = "Game Over!";
            //Debug.Log("Game Over!");
            //Maakt de highscore text en de restartknop zichtbaar.
            GameObject.Find("FinalScoreText").GetComponent<Text>().enabled = true;
            GameObject.Find("RestartButton").GetComponent<Image>().enabled = true;
            GameObject.Find("TextRestartButton").GetComponent<Text>().enabled = true;
            //Hier wordt de highscore text bepaald.
            FinalScoreText.text = "Highscore: " + highScore.count;
        }
    }
}
