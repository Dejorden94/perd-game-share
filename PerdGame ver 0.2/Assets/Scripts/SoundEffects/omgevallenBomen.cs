using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class omgevallenBomen : MonoBehaviour
{
public AudioSource horse;

public AudioSource ouch2;

public AudioSource hitTree;

void OnTriggerEnter(Collider other) 
   {
       horse.Play();
       ouch2.Play();
       hitTree.Play();
   }        
}
