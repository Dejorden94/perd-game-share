using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modder : MonoBehaviour
{
   public AudioSource modderPad;

void OnTriggerEnter(Collider other) 
   {
       modderPad.Play();
   }
}
