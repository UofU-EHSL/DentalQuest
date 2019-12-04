using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class new_position : MonoBehaviour
{
    public Vector3 usefulPosition;
    public Vector3 outOfTheWay;
    public GameObject thing;

    public void useful()
    {
        thing.transform.localPosition = usefulPosition;
    }
    public void GetOut()
    {
        thing.transform.localPosition = outOfTheWay;
    }
}
