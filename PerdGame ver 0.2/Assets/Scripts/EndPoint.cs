using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EndPoint : MonoBehaviour
{
    public Text endText;
    void OnTriggerEnter(Collider other) {
    
   if (other.gameObject.tag == "Player"){
    Cursor.lockState = CursorLockMode.None;
    Cursor.visible = true;

    GameObject.Find("RestartButton").GetComponent<Image>().enabled = true;
    GameObject.Find("TextRestartButton").GetComponent<Text>().enabled = true;
       
    player_movement score = GameObject.Find("Player").GetComponent<player_movement>();
    moodSwitch scene = GameObject.Find("moodIndicator").GetComponent<moodSwitch>();
    Time.timeScale = 0;

       if (score.count < scene.angryPoints)
       {
           SceneManager.LoadScene("badEnding");
           //endText.text = "Try and humiliate the knight more!";
       }
       else if (score.count > scene.angryPoints) 
       {
           SceneManager.LoadScene("goodEnding");
           //endText.text = "Close but you can do better!";
       }
       /*else if (score.count >= 800)
       {
           endText.text = "You showed him who is boss!";
       }*/
       //GameObject.Find("YouWin").GetComponent<Text>().enabled = true;
        }
   }
}
