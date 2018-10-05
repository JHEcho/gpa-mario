using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puase : MonoBehaviour {

    public static bool puase = false;
    public GameObject puasePopup;

    public void PuaseSet()
    {
        puasePopup.SetActive(true);
        puase = true;
    }

    public void PuaseDisable()
    {
        puasePopup.SetActive(false);
        puase = false;
    }

    public void GiveupGame()
    {
        puasePopup.SetActive(false);
        puase = false;
        SceneManager.LoadScene("RoomScene");
    }
}
