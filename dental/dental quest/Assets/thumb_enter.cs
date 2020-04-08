using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thumb_enter : MonoBehaviour
{
    public GameObject finger;
    public bool triggered;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == finger){
            triggered = true;
            GetComponent<Renderer>().material.color = new Color(0.5f, 1, 1);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if(other.gameObject == finger){
            triggered = false;
            GetComponent<Renderer>().material.color = new Color(1, 1, 1);
        }
    }
}
