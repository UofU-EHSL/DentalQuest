using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class userPresent : MonoBehaviour
{
    public UnityEvent events;
    public timer time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time.seconds <= 1 && OVRPlugin.userPresent == false)
        {
            events.Invoke();
            time.seconds = 300;
        }
    }
}