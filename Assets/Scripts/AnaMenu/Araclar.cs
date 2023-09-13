using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Araclar : MonoBehaviour
{
    [SerializeField] GameObject[] Arabalar;
    [SerializeField] GameObject gerii, ilerii;
    public static int aktif = 0;
    void Start()
    {
        if (PlayerPrefs.HasKey("aktifarac"))
        {
            aktif = PlayerPrefs.GetInt("aktifarac");
        }
        Arabalar[aktif].SetActive(true);
    }
    private void Update()
    {
        if (aktif == 0)
        {
            gerii.SetActive(false);
        }
        else
        {
            gerii.SetActive(true);
        }
        if(aktif == Arabalar.Length - 1)
        {
            ilerii.SetActive(false);
        }
        else
        {
            ilerii.SetActive(true);
        }
    }
    public void ileri()
    {
        if (aktif != Arabalar.Length - 1)
        {
            Arabalar[aktif].SetActive(false);
            aktif++;
            PlayerPrefs.SetInt("aktifarac", aktif);
            Arabalar[aktif].SetActive(true);
        }
    }
    public void geri()
    {
        if (aktif != 0)
        {
            Arabalar[aktif].SetActive(false);
            aktif--;
            PlayerPrefs.SetInt("aktifarac", aktif);
            Arabalar[aktif].SetActive(true);
        }
    }
}
