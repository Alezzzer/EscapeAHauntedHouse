using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
   public GameObject inttext, key, lockedText;
   public bool interactable, toggle;
    public AudioSource dooropensound,doorclosesound;
   public Animator doorAnim;

   void OnTriggerStay(Collider other){
        if(other.CompareTag("MainCamera"))
        {
            inttext.SetActive(true);
            interactable = true;
        }
   }

   void OnTriggerExit(Collider other){
        if(other.CompareTag("MainCamera"))
        {
            inttext.SetActive(false);
            interactable = false;
        }
   }

    void Update (){
        if(interactable == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                if(key.active == false)
                {
                    toggle = !toggle;
                    if(toggle == true)
                    {
                        doorAnim.ResetTrigger("close");
                        doorAnim.SetTrigger("open");
                        dooropensound.Play();
                    }
                    if(toggle == false)
                    {
                        doorAnim.ResetTrigger("open");
                        doorAnim.SetTrigger("close");
                        doorclosesound.Play();
                    }
                
                     inttext.SetActive(false);
                     interactable = false;
            }
            
                if(key.active == true)
            {
                lockedText.SetActive(true);
                StopCoroutine("disableText");
                StartCoroutine("disableText");
            }
        }

    }
    }
IEnumerator disableText(){
    yield return new WaitForSeconds(2.0f);
    lockedText.SetActive(false);
}
}
