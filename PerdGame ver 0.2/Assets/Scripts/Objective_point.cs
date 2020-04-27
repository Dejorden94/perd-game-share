using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective_point : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Obejctive gehaald");
        }    
    }
}
