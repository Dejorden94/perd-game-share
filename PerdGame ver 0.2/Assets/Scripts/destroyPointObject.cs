using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyPointObject : MonoBehaviour
{
     void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Player")
        {
           Invoke("destroyGameObject", 0.5f);
        }    
    }
    void destroyGameObject()
    {
        Destroy(this.gameObject);
    }
}
