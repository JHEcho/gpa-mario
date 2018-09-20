using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomUI : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ExitRoom()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
