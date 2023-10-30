using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scaryEventTrigger : MonoBehaviour
{
   public GameObject scare;
   public AudioSource scareSound;
   public Collider collision;

   void OnTriggerEnter(Collider other)
   {
    if(other.CompareTag("Player"))
    {
        scare.SetActive(true);
        //scaresound play
        collision.enabled = false;
        Invoke(nameof(hide),2.0f);
       

    }
    
   }
   void hide(){
    scare.SetActive(false);
   }
 
}
