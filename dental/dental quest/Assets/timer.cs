using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class timer : MonoBehaviour
{

    public Text text;
    public string text_before;
    public float time;
    public int minutes;
    public int seconds;
    public GameObject[] show;
    public GameObject[] hide;
    public bool timing;
    public UnityEvent WhenTimerEnds;
    // Use this for initialization


    void Update()
    {
        if (timing == true)
        {
            time -= Time.deltaTime;
            minutes = Mathf.FloorToInt(time / 60);
            seconds = Mathf.RoundToInt(time - (minutes * 60));
            text.text = text_before + minutes.ToString() + "m " + seconds.ToString() + "s";
            if (time <= 0)
            {
                GameOver();
            }
        }
    }
    public void timer_start()
    {
        time = 300;
        timing = true;
    }
    void GameOver()
    {
        WhenTimerEnds.Invoke();
        timing = false;
        foreach (GameObject item in hide)
        {
            item.SetActive(false);
        }
        foreach (GameObject item in show)
        {
            item.SetActive(true);
        }
    }
}