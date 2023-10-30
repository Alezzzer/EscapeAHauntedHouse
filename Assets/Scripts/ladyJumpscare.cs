using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ladyJumpscare : MonoBehaviour
{
    public Animator ladyAnim;
    public GameObject player;
    public float jumpscareTime;
    public AudioSource ladyKilling;
    public string sceneName;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.SetActive(false);
            ladyAnim.SetTrigger("jumpscare");
            ladyKilling.Play();
            StartCoroutine(jumpscare());
        }
    }
    IEnumerator jumpscare()
    {
        yield return new WaitForSeconds(jumpscareTime);
        SceneManager.LoadScene(sceneName);
    }
}