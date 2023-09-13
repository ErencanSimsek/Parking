using UnityEngine;
using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum Axel
{
    on,arka
}
[Serializable]
public struct Wheel
{
    public GameObject model;
    public WheelCollider collider;
    public Axel axel;
}
public class move : MonoBehaviour
{
    float maksimumHiz = 20.0f, brakeGucu = 9999999999999999999;
    float donusHassasiyeti = 1.0f;
    [SerializeField]
    List<Wheel> wheels;
    float inputX, hiz = 50;
    Rigidbody rb;
    public static bool Gas, Brake, GasBrake = false, brakeGas = false;
    public static int Money = 500, Puan;
    [SerializeField] Text MoneyText, NextText;
    bool ileri = false, geri = false;
    [SerializeField] Image GassSag, GassSol, BrageeSol, BrageeSag, GBackCamera, levelImage, MoneyImage, MoneyTextImage;
    [SerializeField] RawImage BackCamera;
    [SerializeField] Button Continue, Next, NextAgain;
    [SerializeField] Canvas canvas;
    [SerializeField] GameObject  Character, car;
    public static string Vites;
    [SerializeField] AudioSource Engine, menu;
    void brake()
    {
        foreach (var wheel in wheels)
        {
            wheel.collider.brakeTorque = brakeGucu * Time.deltaTime;
        }
    }
    private void Awake()
    {
        Bul();
    }
    private void Start()
    {
        brakeGas = false;
        Brake = false;
        if (PlayerPrefs.HasKey("money"))
        {
            //Money = PlayerPrefs.GetInt("money");
        }
        if(Money == 0)
        {
            Vites = "O";
        }
        else
        {
            Vites = "D";
        }
        if(Money == 0)
        {
            MenuLevel.active = 3;
        }
        MoneyText.text = Money.ToString();
        rb = GetComponent<Rigidbody>();
        brake();
        Puan = 0;
        if (SceneManager.GetActiveScene().name == "level1")
        {
            gameObject.GetComponent<Level1Tanitim>().enabled = true;
        }
        VitesDurum = -1;
    }
    void Bul()
    {
        MoneyText = GameObject.FindWithTag("MoneyText").GetComponent<Text>();
        GassSag = GameObject.FindWithTag("GasSag").GetComponent<Image>();
        GassSol = GameObject.FindWithTag("GasSol").GetComponent<Image>();
        BrageeSag = GameObject.FindWithTag("BrakeSag").GetComponent<Image>();
        BrageeSol = GameObject.FindWithTag("BrakeSol").GetComponent<Image>();
        Next = GameObject.FindWithTag("Next").GetComponent<Button>();
        levelImage = GameObject.FindWithTag("levelImage").GetComponent<Image>();
        NextAgain = GameObject.FindWithTag("NextAgain").GetComponent<Button>();
        NextText = GameObject.FindWithTag("NextText").GetComponent<Text>();
        GBackCamera = GameObject.FindWithTag("GBackCamera").GetComponent<Image>();
        BackCamera = GameObject.FindWithTag("BackCamera").GetComponent<RawImage>();
        Continue = GameObject.FindWithTag("Continue").GetComponent<Button>();
        canvas = GameObject.FindWithTag("Canvas").GetComponent<Canvas>();
        MoneyImage = GameObject.FindWithTag("MoneyImage").GetComponent<Image>();
        MoneyTextImage = GameObject.FindWithTag("MoneyTextImage").GetComponent<Image>();
        Engine = GameObject.FindWithTag("Engine").GetComponent<AudioSource>();
        menu = GameObject.FindWithTag("menu").GetComponent<AudioSource>();
    }
    private void Update()
    {
        AnimateWheels();
        GetInputs();
        if (Puan == 1)
        {
            brake();
        }
        PlayerPrefs.SetInt("money", Money);
    }
    private void GetInputs()
    {
        inputX = SimpleInput.GetAxis("Horizontal");
    }

    private void AnimateWheels()
    {
        foreach (var wheel in wheels)
        {
            Quaternion rot;
            Vector3 pos;
            wheel.collider.GetWorldPose(out pos, out rot);
            wheel.model.transform.position = pos;
            wheel.model.transform.rotation = rot;
        }
    }

    private void LateUpdate()
    {
        Turn();
        Move();
    }
    void gasBrake()
    {
        if (GasBrake == true)
        {
            GasBrake = false;
        }
    }
    public static int VitesDurum = -1;
    void Move()
    {
        if (brakeGas == true)
        {
            car.GetComponent<Rigidbody>().isKinematic = true;
        }
        if (GasBrake == true)
        {
            foreach (var wheel in wheels)
            {
                wheel.collider.brakeTorque = 9999999999999999999 * brakeGucu * Time.deltaTime;
            }
        }
        if (Vites == "D")
        {
            GBackCamera.enabled = false;
            BackCamera.enabled = false;
            if (VitesDurum != 0)
            {
                Engine.Play();
                VitesDurum = 0;
            }
            ForwardCamera.Forward = true;
            ileri = true;
            if (geri == true)
            {
                brake();
                geri = false;
            }
            if (Gas)
            {
                gasBrake();
                foreach (var wheel in wheels)
                {
                    GassSag.color = Color.gray;
                    GassSol.color = Color.gray;
                    wheel.collider.brakeTorque = 0;
                    if(Araclar.aktif == 0)
                    {
                        wheel.collider.motorTorque = maksimumHiz * Car1.CarHiz * Time.deltaTime;
                    }
                    else if (Araclar.aktif == 1)
                    {
                        wheel.collider.motorTorque = maksimumHiz * Car2.CarHiz * Time.deltaTime;
                    }
                    else if (Araclar.aktif == 2)
                    {
                        wheel.collider.motorTorque = maksimumHiz * Car3.CarHiz * Time.deltaTime;
                    }
                }
            }else if (!Gas)
            {
                Durma();
                GassSag.color = Color.white;
                GassSol.color = Color.white;
            }
        }
        else if (Vites == "N")
        {
            GBackCamera.enabled = false;
            BackCamera.enabled = false;
            if (VitesDurum != 1)
            {
                Engine.Play();
                VitesDurum = 1;
            }
            brake();
            GassSag.color = Color.white;
            GassSol.color = Color.white;
        }
        else if(Vites == "R")
        {
            GBackCamera.enabled = true;
            BackCamera.enabled = true;
            if (VitesDurum != 2)
            {
                VitesDurum = 2;

            }
            if (Puan == 0)
            {
                ForwardCamera.Forward = false;
            }
            
            geri = true;
            if (ileri == true)
            {
                brake();
                ileri = false;
            }
            if (Gas)
            {
                gasBrake();
                foreach (var wheel in wheels)
                {
                    GassSag.color = Color.gray;
                    GassSol.color = Color.gray;
                    wheel.collider.brakeTorque = 0;
                    if (Araclar.aktif == 0)
                    {
                        wheel.collider.motorTorque = maksimumHiz * -Car1.CarHiz * Time.deltaTime;
                    }
                    else if (Araclar.aktif == 1)
                    {
                        wheel.collider.motorTorque = maksimumHiz * -Car2.CarHiz * Time.deltaTime;
                    }
                    else if (Araclar.aktif == 2)
                    {
                        wheel.collider.motorTorque = maksimumHiz * -Car3.CarHiz * Time.deltaTime;
                    }
                }
            }
            else if (!Gas)
            {
                Durma();
                GassSag.color = Color.white;
                GassSol.color = Color.white;
            }
        }
        else if(Vites == "P")
        {
            GBackCamera.enabled = false;
            BackCamera.enabled = false;
            if (VitesDurum != 3)
            {
                Engine.Play();
                VitesDurum = 3;
            }
            brake();
            if (parkYeri.Park == 4)
            {
                ContinuePause.menusesi = true;
                ForwardCamera.Forward = true;
                Character.SetActive(true);
                karakter.animasyon = 2;
                Engine.Stop();
                if(Puan == 0)
                {
                    menu.Play();
                    Money += 20;
                    MoneyText.text = Money.ToString();
                    Puan += 1;
                }
                NextText.enabled = true;
                Next.image.enabled = true;
                Next.enabled = true;
                levelImage.enabled = true;
                NextAgain.enabled = true;
                NextAgain.image.enabled = true;
                if(MenuLevel.numara == 16)
                {
                    Next.image.enabled = false;
                    Next.enabled = false;
                }
                Continue.image.enabled = false;
                Continue.enabled = false;
                canvas.enabled = false;
                MoneyImage.enabled = true;
                MoneyTextImage.enabled = true;
                MoneyText.enabled = true;
            }
            GassSag.color = Color.white;
            GassSol.color = Color.white;
        }
        else if(Vites == "O")
        {
            Engine.Stop();
        }

        if (Brake)
        {
            foreach (var wheel in wheels)
            {
                BrageeSag.color = Color.gray;
                BrageeSol.color = Color.gray;
                RightRed.enabled = true;
                LeftRed.enabled = true;
                wheel.collider.brakeTorque = 9999999999999999999 * hiz * Time.deltaTime;
            }
        }
        else if (!Brake)
        {
            BrageeSag.color = Color.white;
            BrageeSol.color = Color.white;
            RightRed.enabled = false;
            LeftRed.enabled = false;
        }
    }
    [SerializeField]
    Light RightRed, LeftRed;
    private void Durma()
    {
        float minHiz = 5, Hiz = 20;
        foreach (var wheel in wheels)
        {
            wheel.collider.motorTorque = minHiz * Hiz * Time.deltaTime;
        }
    }

    private void Turn()
    {
        foreach(var wheel in wheels)
        {
            if(wheel.axel == Axel.on)
            {
                if (Araclar.aktif == 0)
                {
                    var direksiyonAcisi = inputX * donusHassasiyeti * Car1.maksimumYonlendirme;
                    wheel.collider.steerAngle = Mathf.Lerp(wheel.collider.steerAngle, direksiyonAcisi, 0.5f);
                }
                else if (Araclar.aktif == 1)
                {
                    var direksiyonAcisi = inputX * donusHassasiyeti * Car1.maksimumYonlendirme;
                    wheel.collider.steerAngle = Mathf.Lerp(wheel.collider.steerAngle, direksiyonAcisi, 0.5f);
                }
                else if (Araclar.aktif == 2)
                {
                    var direksiyonAcisi = inputX * donusHassasiyeti * Car1.maksimumYonlendirme;
                    wheel.collider.steerAngle = Mathf.Lerp(wheel.collider.steerAngle, direksiyonAcisi, 0.5f);
                }
            }
        }
    }
}
