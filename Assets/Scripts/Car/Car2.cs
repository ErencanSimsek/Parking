using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class Car2 : MonoBehaviour
{
    public static float CarHiz = 50.0f, maksimumYonlendirme = 35.0f, SliderEngine = 5f, SliderSteering = 3.5f;
    private void Start()
    {
        //Hiz
        if (PlayerPrefs.HasKey("Car2Hiz"))
        {
            CarHiz = PlayerPrefs.GetFloat("Car2Hiz");
        }
        if (PlayerPrefs.HasKey("Car2Slider"))
        {
            SliderEngine = PlayerPrefs.GetFloat("Car2Slider");
        }
        //Hiz
        //Yonlendirme
        if (PlayerPrefs.HasKey("Car2Yonlendirme"))
        {
            maksimumYonlendirme = PlayerPrefs.GetFloat("Car2Yonlendirme");
        }
        if (PlayerPrefs.HasKey("Car2SliderSteering"))
        {
            SliderSteering = PlayerPrefs.GetFloat("Car2SliderSteering");
        }
        //Yonlendirme
        ForwardCamera.ofset = new Vector3(0, 3, -5);
    }
}
