using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand_grgab : MonoBehaviour
{
    public GameObject hand;
    public GameObject finger1;
    public GameObject[] finger2;
    public GameObject grab_object;
    public Color fingerTouchouch;
    private GameObject grabParent;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Grabbable" && grab_object == null){
            grab_object = other.gameObject;
        }
    }
    public void OnTriggerExit(Collider other)
    {
            if(other.gameObject == grab_object){
                grab_object = null;
            }
    }

    public void Update()
    {
        foreach(GameObject thumb in finger2){
            if (thumb.GetComponent<thumb_enter>().triggered == true)
            {
                grabParent = grab_object.transform.parent.gameObject;
                grab_object.transform.SetParent(hand.transform);
                thumb.GetComponent<MeshRenderer>().material.color = fingerTouchouch;
                return;
            }
            else
            {
                grab_object.transform.SetParent(grab_object.GetComponent<DrivePost>().initParent.transform);
            }
        }
    }
}
