using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AbutmentAddonType
{
    barbieCup,
    metalSnap,
    washer
}

public class abutment_addon : MonoBehaviour {

    public string addon_name;
    public GameObject init_parent;
    private Vector3 init_location;
    private Quaternion init_rotation;
    public AbutmentAddonType addonType;

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
