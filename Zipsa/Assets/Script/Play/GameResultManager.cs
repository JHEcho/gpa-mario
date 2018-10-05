using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameResultManager : MonoBehaviour {

    public GameObject victoryPopup;
    public GameObject defeatPopup;

    private Timer timer;

    // Use this for initialization
    void Start () {
        timer = GameObject.Find("GameTimerControl").GetComponent<Timer>();
	}
	
	// Update is called once per frame
	void Update () {
        Victory();
        Defeat();
	}

    private void Victory()
    {

    }

    private void Defeat()
    {
        if(timer.time < 0)
        {
            defeatPopup.SetActive(true);
        }
    }

    public void ClosePopup(bool popup) //true = 승리, false = 패배.
    {
        if (popup)
        {
            victoryPopup.SetActive(false);
            SceneManager.LoadScene("RoomScene");
        }
        else
        {
            defeatPopup.SetActive(false);
            SceneManager.LoadScene("RoomScene");
        }
    }
}
