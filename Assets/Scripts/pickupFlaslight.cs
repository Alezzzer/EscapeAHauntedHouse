using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupFlaslight : MonoBehaviour
{
   public GameObject inttext, flashlight_table, flashlight_hand;
   public AudioSource pickup;
   public bool interactable;

   void OnTriggerStay(Collider other){
        if(other.CompareTag("MainCamera"))
        {
            inttext.SetActive(true);
            interactable = true;
        }

   }

   void OnTriggerExit(Collider other)
   {
        if(other.CompareTag("MainCamera")){
            inttext.SetActive(false);
            interactable = false;
        }

   }

    void Update(){
        if(interactable == true)

            if(Input.GetKeyDown(KeyCode.E)){
                inttext.SetActive(false);
                interactable = false;
                //pickup play()
                flashlight_hand.SetActive(true);
                flashlight_table.SetActive(false);
            }

    }
}
