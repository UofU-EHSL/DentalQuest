using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zinnia.Data.Type.Transformation.Conversion;

public class fly : MonoBehaviour
{
    public GameObject tooth;
    public FloatToVector2 controller;
    public GameObject player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tooth.transform.position = tooth.transform.position + Camera.main.transform.forward * (controller.GetComponent<FloatToVector2>().CurrentY*speed) * Time.deltaTime;
    }
}