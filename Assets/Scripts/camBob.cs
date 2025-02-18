using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camBob : MonoBehaviour
{
    public Animator cameraAnim;
    public bool walking;

    void Update(){

        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            walking = true;
            cameraAnim.ResetTrigger("idle");
            cameraAnim.ResetTrigger("sprint");
            cameraAnim.SetTrigger("walk");
            if(walking == true)
            {
                if(Input.GetKey(KeyCode.LeftShift))
                {
                    cameraAnim.ResetTrigger("walk");
                    cameraAnim.ResetTrigger("idle");
                    cameraAnim.SetTrigger("sprint");
                }
            }  
        }
        else{
                    cameraAnim.ResetTrigger("walk");
                    cameraAnim.ResetTrigger("sprint");
                    cameraAnim.SetTrigger("idle");
                    walking = false;
        }
    }
}
