using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impressions : MonoBehaviour {

    public GameObject abutmentGameobject;
    public GameObject abutmentOGParent;
    public Quaternion rotaion;
    public Vector3 location;
    public Vector3 scale;
    private Vector3 OGscale;

    private void Update()
    {

        /*
        abutmentGameobject = gameObject.transform.GetChild(0).gameObject;
        rotaion = abutmentGameobject.transform.localRotation;
        location = abutmentGameobject.transform.localPosition;
        scale = abutmentGameobject.transform.localScale;
        */
        if (gameObject.GetComponent<MeshRenderer>().enabled == false)
        {
            gameObject.GetComponent<SphereCollider>().enabled = false;
        }
        else
        {
            gameObject.GetComponent<SphereCollider>().enabled = true;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<abutment>().abutmentType == AbutmentType.SingleUnitImpressionCouping) {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        abutmentGameobject = null;
        other.gameObject.transform.SetParent(abutmentOGParent.transform);
    }
}