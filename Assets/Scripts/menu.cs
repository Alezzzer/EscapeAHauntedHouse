using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public GameObject menuObj, controlsObj;
    public string sceneName, sceneName2;
    public Button continueButton;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    void Update()
    {
        if(PlayerPrefs.GetInt("level") == 0)
        {
            continueButton.interactable = false;
        }
    }
    public void playGame()
    {
        menuObj.SetActive(true);
        PlayerPrefs.SetInt("level", 1);
        PlayerPrefs.Save();
        SceneManager.LoadScene(sceneName);
    }
    public void continueGame()
    {
        menuObj.SetActive(true);
        if(PlayerPrefs.GetInt("level", 2) == 2)
        {
            SceneManager.LoadScene(sceneName2);
        }
        if (PlayerPrefs.GetInt("level", 1) == 1)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
public void controlsMenu(){
    menuObj.SetActive(false);
    controlsObj.SetActive(true);
}

    public void quitGame()
    {
        Debug.Log("This will quit the game, only works in actual build, not in Unity editor.");
        Application.Quit();
    }
    public void linkedin()
    {
        Application.OpenURL("https://www.linkedin.com/in/aleksandar-zeradjanin-790898218/");
    }

    public void backToMenu(){
        controlsObj.SetActive(false);
        menuObj.SetActive(true);
    }
}