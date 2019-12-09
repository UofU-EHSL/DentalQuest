﻿using System.Collections;
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
    private GameObject init_parent;
    private Vector3 init_loation;
    private Quaternion init_rotation;
    private Vector3 init_scale;
    public float addon_offset;
    public AbutmentType abutmentType;


    public void Start()
    {
        init_loation = gameObject.transform.position;
        init_rotation = gameObject.transform.rotation;
        init_parent = gameObject.transform.parent.gameObject;
        init_scale = gameObject.transform.localScale;
    }
    public void set_in(Transform parent, Vector3 location, Quaternion rotation, float scale)
    {
        gameObject.transform.parent = parent;
        gameObject.transform.localPosition = location;
        gameObject.transform.localRotation = rotation;
        gameObject.transform.localScale = init_scale * scale;

    }
    public void Reset_init()
    {
        gameObject.transform.SetParent(init_parent.transform);
        gameObject.transform.position = init_loation;
        gameObject.transform.rotation = init_rotation;
    }
}