using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class DataPoint
{
    public GameObject text;
    public string form_id;
    public string data;
    public bool Transform;
    public bool Rotation;
    public bool getParent;
}

public class DrivePost : MonoBehaviour
{
    public GameObject initParent;
    public DataPoint[] item;
    public bool test;
    public bool moveToValidationPoints;
    public Vector3 validationLocation;
    public Quaternion validationRotation;
    public void Start()
    {
        initParent = this.gameObject.transform.parent.gameObject;
    }
    public void Submit()
    {
        foreach (DataPoint subData in item)
        {
            if (subData.text.GetComponent<Text>())
            {
                if (subData.text.GetComponent<Text>().text == "/")
                {
                    return;
                }
            }
        }
        StartCoroutine(Post());
    }

    public void Update()
    {
        if (test == true)
        {
            Submit();
            test = false;
        }
        if(moveToValidationPoints){
            this.gameObject.transform.localPosition = validationLocation;
            this.gameObject.transform.localRotation = validationRotation;
        }
    }
    [SerializeField]
    public string BASE_URL;
    IEnumerator Post()
    {
        WWWForm form = new WWWForm();

        foreach (DataPoint thing in item)
        {
            if (thing.text.GetComponent<Text>())
            {
                thing.data = thing.text.GetComponent<Text>().text;
            }
            else if (thing.text.GetComponent<TextMeshProUGUI>())
            {
                thing.data = thing.text.GetComponent<TextMeshProUGUI>().text;
            }
            else if (thing.Transform) {
                thing.data = thing.text.transform.localPosition.ToString("F4");
            }
            else if (thing.Rotation)
            {
                thing.data = thing.text.transform.localRotation.ToString("F4");
            }
            else if (thing.getParent)
            {
                thing.data = this.gameObject.transform.parent.gameObject.name;
            }
            else
            {
                thing.data = thing.text.name;
            }


            form.AddField(thing.form_id, thing.data);
        }

        byte[] rawData = form.data;
        WWW www = new WWW(BASE_URL + "/formResponse", rawData);
        yield return www;
    }
}
