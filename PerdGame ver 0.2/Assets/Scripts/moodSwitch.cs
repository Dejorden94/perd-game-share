using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moodSwitch : MonoBehaviour
{
    Image myImageComponent;

    //Hier worden de afbeeldingen gevraagt die de mood laten zien van de ridder. 
    public Sprite moodSmug;
    public Sprite moodNeutral;
    public Sprite moodAngry;

    //hier kan je de punten vernaderen die de speler moet halen om een andere afbeelding te krijgen.
    public int neutralPoints = 300;
    public int angryPoints = 600;

    // Start is called before the first frame update
    void Start()
    {
        myImageComponent = GetComponent<Image>();
        
    }

    public void SetImage()
    {
        player_movement currentScore = GameObject.Find("Player").GetComponent<player_movement>();
        
        if (currentScore.count < neutralPoints)
        {
            Debug.Log("SMUG");
            myImageComponent.sprite = moodSmug;
        }
        else if (currentScore.count >= neutralPoints && currentScore.count < angryPoints)
        {
            Debug.Log("NEUTRAL");
            myImageComponent.sprite = moodNeutral;
        }
        else if (currentScore.count >= angryPoints)
        {
            Debug.Log("ANGRY");
            myImageComponent.sprite = moodAngry;
        }
    }
}
