using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bijenKorf : MonoBehaviour
{

public AudioSource bijen;

public AudioSource ouch;

public AudioSource hit;

void OnTriggerEnter(Collider other) 
   {
       bijen.Play();
       ouch.Play();
       hit.Play();
   }
}
