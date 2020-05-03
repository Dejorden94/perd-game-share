using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntenTelling : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other) 
    {
        player_movement target = GameObject.Find("Player").GetComponent<player_movement>();

        if (other.gameObject.tag == "Points")
        {
            target.count = target.count + 100;
            target.SetCountText ();
            target.script.SetImage();
        }
    }
}
