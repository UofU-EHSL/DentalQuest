using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class implant : MonoBehaviour {
    public Vector3 size;
    private GameObject init_parent;
    private Vector3 init_location;
    private Quaternion init_rotation;
    private Vector3 init_scale;
    public GameObject grabObject;
    public void Start()
    {
        init_location = init_parent.transform.position;
        init_rotation = init_parent.transform.rotation;
    }
    public void Reset_init()
    {
        //grabObject.transform.SetParent(init_parent.transform);
        grabObject.transform.position = init_location;
        grabObject.transform.rotation = init_rotation;

        init_parent.GetComponent<Rigidbody>().velocity = Vector3.zero;
        init_parent.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}