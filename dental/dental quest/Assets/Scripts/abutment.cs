using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum AbutmentType
{
    SingleUnitImpressionCouping,
    MultiUnitImpressionCouping,
    SmallLocator,
    MidLocator,
    LargeLocator,
}

public class abutment : MonoBehaviour {
    public string abutment_name;
    public GameObject init_parent;
    private Vector3 init_location;
    private Quaternion init_rotation;
    private Vector3 init_scale;
    public float addon_offset;
    public AbutmentType abutmentType;


    public void Start()
    {
        init_location = init_parent.transform.position;
        init_rotation = init_parent.transform.rotation;
    }

    public void Reset_init()
    {
        init_parent.transform.position = init_location;
        init_parent.transform.rotation = init_rotation;

        init_parent.GetComponent<Rigidbody>().velocity = Vector3.zero;
        init_parent.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
    }
}