using UnityEngine.UI;
using UnityEngine;
using System;

public class AgainMenu : MonoBehaviour
{
    [SerializeField] GameObject Character, _6B, _4B, _2B, _6F, _4F, _2F, kolu;
    [SerializeField] Button Continue, Again, ileri2, geri2, NoMoney;
    [SerializeField] Canvas canvas;
    [SerializeField] Image MoneyImage, MoneyTextImage, kilit2, levelImage2, levelImage3, TimeCounter;
    [SerializeField] AudioSource Engine, menu;
    [SerializeField] Text MoneyText, AgainText, NoMoneyText, Minute, Second, nokta;
    [SerializeField] AudioSource GeriVites;
    [SerializeField] Camera kamera, arkaKamera;
    public static bool bNoMoney = false, bAgain = false;

    private void Awake()
    {
        bul();
    }
    private void Start()
    {
        if (move.Money == 0)
        {
            MenuLevel.active = 3;
        }
        if (MenuLevel.active == 3)
        {
            Engine.Stop();
            money();
        }
        else if(MenuLevel.active == 2)
        {
            Engine.Stop();
            again();
        }
    }

    private void bul()
    {
        kolu = GameObject.Find("Kol");
        canvas = GameObject.FindWithTag("Canvas").GetComponent<Canvas>();
        MoneyImage = GameObject.FindWithTag("MoneyImage").GetComponent<Image>();
        MoneyTextImage = GameObject.FindWithTag("MoneyTextImage").GetComponent<Image>();
        Continue = GameObject.FindWithTag("Continue").GetComponent<Button>();
        Engine = GameObject.FindWithTag("Engine").GetComponent<AudioSource>();
        menu = GameObject.FindWithTag("menu").GetComponent<AudioSource>();
        kamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        arkaKamera = GameObject.FindWithTag("ArkaCamera").GetComponent<Camera>();
        Again = GameObject.FindWithTag("Again").GetComponent<Button>();
        NoMoney = GameObject.FindWithTag("Money").GetComponent<Button>();
        ileri2 = GameObject.FindWithTag("ileri2").GetComponent<Button>();
        geri2 = GameObject.FindWithTag("geri2").GetComponent<Button>();
        kilit2 = GameObject.FindWithTag("kilit2").GetComponent<Image>();
        levelImage2 = GameObject.FindWithTag("levelImage2").GetComponent<Image>();
        levelImage3 = GameObject.FindWithTag("levelImage3").GetComponent<Image>();
        AgainText = GameObject.FindWithTag("AgainText").GetComponent<Text>();
        NoMoneyText = GameObject.FindWithTag("NoMoneyText").GetComponent<Text>();
        TimeCounter = GameObject.FindWithTag("TimeCounter").GetComponent<Image>();
        Minute = GameObject.FindWithTag("Minute").GetComponent<Text>();
        Second = GameObject.FindWithTag("Second").GetComponent<Text>();
        MoneyText= GameObject.FindWithTag("MoneyText").GetComponent<Text>();
        nokta = GameObject.FindWithTag("nokta").GetComponent<Text>();
        _6B = GameObject.FindWithTag("_6B");
        _4B = GameObject.FindWithTag("_4B");
        _2B = GameObject.FindWithTag("_2B");
        _6F = GameObject.FindWithTag("_6F");
        _4F = GameObject.FindWithTag("_4F");
        _2F = GameObject.FindWithTag("_2F");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("NoWay") || collision.gameObject.CompareTag("0") || collision.gameObject.CompareTag("1")
            || collision.gameObject.CompareTag("2") || collision.gameObject.CompareTag("3") || collision.gameObject.CompareTag("4"))
        {
            noway();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NoWay") || other.gameObject.CompareTag("0") || other.gameObject.CompareTag("1")
            || other.gameObject.CompareTag("2") || other.gameObject.CompareTag("3") || other.gameObject.CompareTag("4"))
        {
            noway();
        }
    }
    void ContinueAgainNoMoney()
    {
        level1.ContinueAgainNoMoney = true;
        level2.ContinueAgainNoMoney = true;
        level3.ContinueAgainNoMoney = true;
        level4.ContinueAgainNoMoney = true;
        level5.ContinueAgainNoMoney = true;
        level6.ContinueAgainNoMoney = true;
        level7.ContinueAgainNoMoney = true;
        level8.ContinueAgainNoMoney = true;
        level9.ContinueAgainNoMoney = true;
        level10.ContinueAgainNoMoney = true;
        level11.ContinueAgainNoMoney = true;
        level12.ContinueAgainNoMoney = true;
        level13.ContinueAgainNoMoney = true;
        level14.ContinueAgainNoMoney = true;
        level15.ContinueAgainNoMoney = true;
        level16.ContinueAgainNoMoney = true;
    }
    void noway()
    {
        ContinueAgainNoMoney();
        if (move.Money == 0)
        {
            money();
        }
        else if(move.Money > 20)
        {
            again();
        }
        if (move.Puan == 0)
        {
            move.brakeGas = true;
            move.Gas = false;
            move.Brake = false;
            move.Money -= 20;
            MoneyText.text = move.Money.ToString();
            move.Puan += 1;
            ForwardCamera.Forward = true;
        }
        
    }
    void money()
    {
        moneyAgain();
        kolu.SetActive(false);
        TimeCounter.enabled = true;
        nokta.enabled = true;
        Minute.enabled = true;
        Second.enabled = true;
        bNoMoney = true;
        NoMoney.enabled = true;
        NoMoney.image.enabled = true;
        levelImage3.enabled = true;
        NoMoneyText.enabled = true;
    }
    void again()
    {
        moneyAgain();
        bAgain = true;
        Again.enabled = true;
        Again.image.enabled = true;
        ileri2.enabled = true;
        ileri2.image.enabled = true;
        if (MenuLevel.numara != 1)
        {
            geri2.enabled = true;
            geri2.image.enabled = true;
        }
        kilit2.enabled = true;
        levelImage2.enabled = true;
        AgainText.enabled = true;
    }
    void moneyAgain()
    {
        ContinuePause.menusesi = true;
        parkYeri.Park = 0;
        Character.SetActive(true);
        karakter.animasyon = 3;
        menu.Play();
        Engine.Pause();
        _6B.SetActive(false);
        _4B.SetActive(false);
        _2B.SetActive(false);
        _6F.SetActive(false);
        _4F.SetActive(false);
        _2F.SetActive(false);
        canvas.enabled = false;
        Continue.enabled = false;
        Continue.image.enabled = false;
        MoneyImage.enabled = true;
        MoneyTextImage.enabled = true;
        MoneyText.enabled = true;
    }
}
