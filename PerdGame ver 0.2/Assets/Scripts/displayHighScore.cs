using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayHighScore : MonoBehaviour
{
    public Text HighscoreText;
    // Start is called before the first frame update
    void Start()
    {
        displayHighscore();
    }

    void displayHighscore()
    {
        player_movement highscore = GameObject.Find("Player").GetComponent<player_movement>();
        HighscoreText.text = "Highscore: " + highscore.count;
    }
}
