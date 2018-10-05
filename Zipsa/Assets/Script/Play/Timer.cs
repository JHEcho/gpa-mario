using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public int time;
    GameObject timerText;

	// Use this for initialization
	void Start () {
        this.timerText = GameObject.Find("Timer");
        StartCoroutine("RunTimer");
    }
	
	// Update is called once per frame
	void Update () {

    }
    IEnumerator RunTimer()
    {
        while (true)
        {
            if (!Puase.puase)
            {
                this.timerText.GetComponent<Text>().text = (time / 60) + ":" + (time % 60);
                time -= 1;
            }
            yield return new WaitForSeconds(1f);
        }
    }
}
