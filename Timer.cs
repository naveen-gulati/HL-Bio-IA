using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public bool finished = true; 
    private float startTime;
    public GameObject ant;
    private Player value;
    public void ClickTheButtonOff()
    {
        finished = true;
    }
    public void ClickTheButtonOn()
    {
        finished = false;
        startTime = Time.time;
    }
    // Start is called before the first frame update
    void Start()
    {
        value = ant.GetComponent<Player>();
    }
    // Update is called once per frame
    void Update()
    {
        int total = value.ClickCount;
        if (finished == true)
        {
            return;
        }
        else if(finished == false)
        {
            float t = Time.time - startTime;

            string minutes = ((int) t/60).ToString();
            string seconds = (t % 60).ToString("f2");

            timerText.text = minutes + ":" + seconds;
            Debug.Log(timerText.text);
        }
    }
}
