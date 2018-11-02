using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {

    public Text TimerText;

    private float StartTime;

    private bool Finished = false;

	// Use this for initialization
	void Start () {
        StartTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (Finished)
        {
            return;
        }
        float currentTime = Time.time - StartTime;

        string minutes = ((int)currentTime / 60).ToString();
        string seconds = (currentTime % 60).ToString("f2");

        TimerText.text = minutes + ":" + seconds;
	}

    public void Finish()
    {
        Finished = true;
        TimerText.color = Color.yellow;
    }
}
