using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ContinuePause : MonoBehaviour
{
    [SerializeField] GameObject Continue, Pause, Canvas, ContinuePausePanel, SettingsPanel, Settings, soundOn, soundOff, Sag, Sol, carSoundOn, carSoundOff;
    Image MoneyImage, MoneyTextImage;
    Text MoneyText;
    [SerializeField] Button geri;
    [SerializeField] Image direksiyonSag, direksiyonSol, GasSag, GasSol, BrakeSag, BrakeSol;
    [SerializeField] AudioSource Engine, menu; 
    GameObject _6B, _4B, _2B, _6F, _4F, _2F;
    public static bool bContinue = false, menusesi = false;
    public static int SagSol = 1;
    private void Start()
    {
        menusesi = false;
        bul();
        if (MenuLevel.active == 1)
        {
            move.VitesDurum = 0;
            move.Vites = "O";
            contiune();
        }
        if (PlayerPrefs.HasKey("sound"))
        {
            AnaMenu.sound = PlayerPrefs.GetInt("sound");
        }
        if (PlayerPrefs.HasKey("carsound"))
        {
            AnaMenu.carSound = PlayerPrefs.GetInt("carsound");
        }
        if (AnaMenu.sound == 0)
        {
            menu.enabled = true;
            Engine.enabled = true;
            soundOn.SetActive(true);
            soundOff.SetActive(false);
            PlayerPrefs.SetInt("sound", AnaMenu.sound);
        }
        else if (AnaMenu.sound == 1)
        {
            menu.enabled = false;
            Engine.enabled = false;
            soundOn.SetActive(false);
            soundOff.SetActive(true);
            PlayerPrefs.SetInt("sound", AnaMenu.sound);
        }
        if (PlayerPrefs.HasKey("SagSol"))
        {
            SagSol = PlayerPrefs.GetInt("SagSol");
        }
        if(SagSol == 1)
        {
            Sag.SetActive(false);
            Sol.SetActive(true);
            direksiyonSag.enabled = false;
            direksiyonSol.enabled = true;
            GasSag.enabled = false;
            GasSol.enabled = true;
            BrakeSol.enabled = true;
            BrakeSag.enabled = false;
        }
        else if(SagSol == 0)
        {
            Sol.SetActive(false);
            Sag.SetActive(true);
            direksiyonSag.enabled = true;
            direksiyonSol.enabled = false;
            GasSag.enabled = true;
            GasSol.enabled = false;
            BrakeSol.enabled = false;
            BrakeSag.enabled = true;
        }
        if (AnaMenu.carSound == 0)
        {
            if(move.Money != 0)
            {
                Engine.enabled = true;
                Engine.Pause();
                carSoundOn.SetActive(true);
                carSoundOff.SetActive(false);
                _6B.SetActive(true);
                _4B.SetActive(true);
                _2B.SetActive(true);
                _6F.SetActive(true);
                _4F.SetActive(true);
                _2F.SetActive(true);
            }
        }
        else if (AnaMenu.carSound == 1)
        {
            _6B.SetActive(false);
            _4B.SetActive(false);
            _2B.SetActive(false);
            _6F.SetActive(false);
            _4F.SetActive(false);
            _2F.SetActive(false);
            Engine.enabled = false;
            carSoundOn.SetActive(false);
            carSoundOff.SetActive(true);
        }
    }
    private void bul()
    {
        MoneyTextImage = GameObject.FindWithTag("MoneyTextImage").GetComponent<Image>();
        MoneyText = GameObject.FindWithTag("MoneyText").GetComponent<Text>();
        MoneyImage = GameObject.FindWithTag("MoneyImage").GetComponent<Image>();
        _6B = GameObject.FindWithTag("_6B");
        _4B = GameObject.FindWithTag("_4B");
        _2B = GameObject.FindWithTag("_2B");
        _6F = GameObject.FindWithTag("_6F");
        _4F = GameObject.FindWithTag("_4F");
        _2F = GameObject.FindWithTag("_2F");
    }
    void ContinueAgainNoMoneyTrue()
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
    public void contiune()
    {
        ContinueAgainNoMoneyTrue();
        menusesi = true;
        menu.Play();
        Engine.Pause();
        _6B.SetActive(false);
        _4B.SetActive(false);
        _2B.SetActive(false);
        _6F.SetActive(false);
        _4F.SetActive(false);
        _2F.SetActive(false);
        bContinue = true;
        GeriEnabled();
        Time.timeScale = 0;
        MoneyImage.enabled = true;
        MoneyText.enabled = true;
        MoneyTextImage.enabled = true;
        Pause.SetActive(true);
        ContinuePausePanel.SetActive(true);
        Settings.SetActive(true);
        Canvas.SetActive(false);
        Continue.SetActive(false);
    }
    public void SoundOff()
    {
        AnaMenu.sound = 0;
        menu.enabled = true;
        menu.Play();
        soundOn.SetActive(true);
        soundOff.SetActive(false);
        PlayerPrefs.SetInt("sound", AnaMenu.sound);
    }
    public void SoundOn()
    {
        AnaMenu.sound = 1;
        menu.enabled = false;
        soundOn.SetActive(false);
        soundOff.SetActive(true);
        PlayerPrefs.SetInt("sound", AnaMenu.sound);
    }
    public void CarSoundOn()
    {
        AnaMenu.carSound = 1;
        Engine.enabled = false;
        carSoundOn.SetActive(false);
        carSoundOff.SetActive(true);
        PlayerPrefs.SetInt("carsound", AnaMenu.carSound);
    }
    public void CarSoundOff()
    {
        AnaMenu.carSound = 0;
        Engine.enabled = true;
        Engine.Pause();
        carSoundOn.SetActive(true);
        carSoundOff.SetActive(false);
        PlayerPrefs.SetInt("carsound", AnaMenu.carSound);
    }
    void Play()
    {
        if(move.Vites == "D" || move.Vites == "N" || move.Vites == "P" || move.Vites == "R")
        {
            Engine.Play();
        }
    }
    void ContinueAgainNoMoneyFalse()
    {
        level1.ContinueAgainNoMoney = false;
        level2.ContinueAgainNoMoney = false;
        level3.ContinueAgainNoMoney = false;
        level4.ContinueAgainNoMoney = false;
        level5.ContinueAgainNoMoney = false;
        level6.ContinueAgainNoMoney = false;
        level7.ContinueAgainNoMoney = false;
        level8.ContinueAgainNoMoney = false;
        level9.ContinueAgainNoMoney = false;
        level10.ContinueAgainNoMoney = false;
        level11.ContinueAgainNoMoney = false;
        level12.ContinueAgainNoMoney = false;
        level13.ContinueAgainNoMoney = false;
        level14.ContinueAgainNoMoney = false;
        level15.ContinueAgainNoMoney = false;
        level16.ContinueAgainNoMoney = false;
    }
    private void Update()
    {
        if (menusesi == false && move.Money != 0)
        {
            menu.Pause();
        }
    }
    public void pause()
    {
        if(MenuLevel.active == 1)
        {
            move.Vites = "D";
        }
        GeriDisabled();
        ContinueAgainNoMoneyFalse();
        menu.Pause();
        menusesi = false;
        Play();
        if(AnaMenu.carSound == 0)
        {
            _6B.SetActive(true);
            _4B.SetActive(true);
            _2B.SetActive(true);
            _6F.SetActive(true);
            _4F.SetActive(true);
            _2F.SetActive(true);
        }
        FSensor._6s = false;
        FSensor._4s = false;
        FSensor._2s = false;
        BSensor._6s = false;
        BSensor._4s = false;
        BSensor._2s = false;
        move.GasBrake = true;
        move.Gas = false;
        move.Brake = false;
        bContinue = false;
        Time.timeScale = 1;
        MoneyImage.enabled = false;
        MoneyText.enabled = false;
        MoneyTextImage.enabled = false;
        Pause.SetActive(false);
        ContinuePausePanel.SetActive(false);
        Settings.SetActive(false);
        Canvas.SetActive(true);
        Continue.SetActive(true);
    }
    public static int set = 0;
    public void settings()
    {
        ContinueAgainNoMoneyFalse();
        set = 2;
        GeriDisabled();
        Pause.SetActive(false);
        ContinuePausePanel.SetActive(false);
        SettingsPanel.SetActive(true);
        Settings.SetActive(false);
    }
    public void BackSettings()
    {
        ContinueAgainNoMoneyTrue();
        set = 1;
        GeriEnabled();
        Settings.SetActive(true);
        Pause.SetActive(true);
        ContinuePausePanel.SetActive(true);
        SettingsPanel.SetActive(false);
    }
    
    public void DireksiyonSag()
    {
        SagSol = 1;
        Sag.SetActive(false);
        Sol.SetActive(true);
        direksiyonSag.enabled = false;
        direksiyonSol.enabled = true;
        GasSag.enabled = false;
        GasSol.enabled = true;
        BrakeSol.enabled = true;
        BrakeSag.enabled = false;
        PlayerPrefs.SetInt("SagSol", SagSol);
    }
    public void DireksiyonSol()
    {
        SagSol = 0;
        Sag.SetActive(true);
        Sol.SetActive(false);
        direksiyonSag.enabled = true;
        direksiyonSol.enabled = false;
        GasSag.enabled = true;
        GasSol.enabled = false;
        BrakeSol.enabled = false;
        BrakeSag.enabled = true;
        PlayerPrefs.SetInt("SagSol", SagSol);
    }
    public void home()
    {
        SceneManager.LoadScene("AnaMenu");
        parkYeri.Park = 0;
        Time.timeScale = 1;
        move.GasBrake = true;
        menusesi = false;
    }
    void GeriEnabled()
    {
        if (MenuLevel.numara != 1)
        {
            geri.enabled = true;
            geri.image.enabled = true;
        }
    }
    void GeriDisabled()
    {
        if (MenuLevel.numara != 1)
        {
            geri.enabled = false;
            geri.image.enabled = false;
        }
    }
}
