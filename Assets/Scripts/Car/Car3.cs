using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class Car3 : MonoBehaviour
{
    public static float CarHiz = 55.0f, maksimumYonlendirme = 40.0f, SliderEngine = 5.5f, SliderSteering = 4;
    private void Start()
    {
        //Hiz
        if (PlayerPrefs.HasKey("Car3Hiz"))
        {
            CarHiz = PlayerPrefs.GetFloat("Car3Hiz");
        }
        if (PlayerPrefs.HasKey("Car3Slider"))
        {
            SliderEngine = PlayerPrefs.GetFloat("Car3Slider");
        }
        //Hiz
        //Yonlendirme
        if (PlayerPrefs.HasKey("Car3Yonlendirme"))
        {
            maksimumYonlendirme = PlayerPrefs.GetFloat("Car3Yonlendirme");
        }
        if (PlayerPrefs.HasKey("Car3SliderSteering"))
        {
            SliderSteering = PlayerPrefs.GetFloat("Car3SliderSteering");
        }
        //Yonlendirme
        ForwardCamera.ofset = new Vector3(0, 2, -6);
    }
}
