using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour {

    public void StartBegin()
    {
        SceneManager.LoadScene("StoryPage");
    }
    public void StartLoad()
    {
        SceneManager.LoadScene("Room");
    }
}
