using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class Car1 : MonoBehaviour
{
    public static float CarHiz = 45.0f, maksimumYonlendirme = 30.0f, SliderEngine = 4.5f, SliderSteering = 3;
    private void Start()
    {
        //Hiz
        if (PlayerPrefs.HasKey("Car1Hiz"))
        {
            CarHiz = PlayerPrefs.GetFloat("Car1Hiz");
        }
        if (PlayerPrefs.HasKey("Car1Slider"))
        {
            SliderEngine = PlayerPrefs.GetFloat("Car1Slider");
        }
        //Hiz
        //Yonlendirme
        if (PlayerPrefs.HasKey("Car1Yonlendirme"))
        {
            maksimumYonlendirme = PlayerPrefs.GetFloat("Car1Yonlendirme");
        }
        if (PlayerPrefs.HasKey("Car1SliderSteering"))
        {
            SliderSteering = PlayerPrefs.GetFloat("Car1SliderSteering");
        }
        //Yonlendirme
        ForwardCamera.ofset = new Vector3(0, 3, -5);
    }
}
