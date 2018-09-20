using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    private int leftTime = 1;
    private float nextTime = 0.0f;
    GameObject timerText;

	// Use this for initialization
	void Start () {
        this.leftTime *= (3*60);
        this.timerText = GameObject.Find("Timer");
    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextTime)
        {
            nextTime += 1;
            this.leftTime -= 1;
            this.timerText.GetComponent<Text>().text = (leftTime / 60) + ":" + (leftTime % 60);
        }
    }
}
