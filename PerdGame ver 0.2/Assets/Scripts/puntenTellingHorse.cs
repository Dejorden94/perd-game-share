using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntenTellingHorse : MonoBehaviour
{
   void OnTriggerEnter(Collider other) 
    {
        Debug.Log("Hallo?");
        player_movement target = GameObject.Find("Player").GetComponent<player_movement>();

      /*  if (other.gameObject.tag == "PointsGround")
        {
            Debug.Log("PUNTEN!!!");
            target.count = target.count + 100;
            target.SetCountText ();
            target.script.SetImage();
        }*/ 
    }
}
