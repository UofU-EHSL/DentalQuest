using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move_teeth : MonoBehaviour
{
    public GameObject[] moveObject;
    public Text text;
    public float value;
    public float scale;

    public void updateValue(float buttonValue)
    {
        value = value+buttonValue;
        foreach (GameObject thing in moveObject)
        {
            thing.transform.localPosition = new Vector3(thing.transform.localPosition.x, value*scale, thing.transform.localPosition.z);
        }
        if (text) {
            text.text = value.ToString("F2") + "mm";
        }
    }
}
