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
        init_location = grabObject.transform.position;
        init_rotation = grabObject.transform.rotation;
        init_parent = grabObject.transform.parent.gameObject;
        init_scale = grabObject.transform.localScale;
    }
    public void Reset_init()
    {
        grabObject.transform.SetParent(init_parent.transform);
        grabObject.transform.position = init_location;
        grabObject.transform.rotation = init_rotation;
    }
}