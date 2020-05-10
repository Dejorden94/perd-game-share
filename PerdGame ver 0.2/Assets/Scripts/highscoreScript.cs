using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highscoreScript : MonoBehaviour
{
    void Awake() 
    {
        DontDestroyOnLoad(this.gameObject);    
    }

    // Update is called once per frame
    void Update()
    {
        player_movement highscore = GameObject.Find("Player").GetComponent<player_movement>();
        Debug.Log(highscore.count);
    }
}
