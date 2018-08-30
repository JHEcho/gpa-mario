using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour {

    public GameObject exitPopup;

    public void StartBegin()
    {
        SceneManager.LoadScene("StoryPage");
    }
    public void StartLoad()
    {
        SceneManager.LoadScene("Room");
    }
    public void Exitbutten()
    {
        exitPopup.SetActive(true);
    }
    public void ExitCancel()
    {
        exitPopup.SetActive(false);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
