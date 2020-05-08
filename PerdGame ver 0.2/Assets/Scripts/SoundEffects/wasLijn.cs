using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wasLijn : MonoBehaviour
{

    public AudioSource ouch3;

    public AudioSource hitWaslijn;

void OnTriggerEnter(Collider other) 
   {
       ouch3.Play();
       hitWaslijn.Play();
   }
}
