using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{
   public AudioSource splash;

void OnTriggerEnter(Collider other) 
   {
       splash.Play();
   }
}
