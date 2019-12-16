using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impressions : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<abutment>().abutmentType == AbutmentType.SingleUnitImpressionCouping) {
            this.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }else if (other.GetComponent<abutment_addon>().addonType == AbutmentAddonType.replica)
        {
            this.gameObject.transform.GetChild(1).gameObject.SetActive(true);
        }
    }
}