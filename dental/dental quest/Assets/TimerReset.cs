using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerReset : MonoBehaviour
{
    public GameObject[] teeth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void reset_everything()
    {
        foreach (GameObject tooth in teeth)
        {
            tooth.transform.localPosition = Vector3.zero;
            tooth.transform.localRotation = new Quaternion(0,0,0,0);
        }
    }
}
