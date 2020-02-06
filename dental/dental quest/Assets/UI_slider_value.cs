using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_slider_value : MonoBehaviour
{
    public VRBasics_Slider slider;
    public TextMeshProUGUI text;
    public void Update()
    {
        text.text = slider.position.ToString();
    }
}
