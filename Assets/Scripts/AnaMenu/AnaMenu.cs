using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AnaMenu : MonoBehaviour
{
    [SerializeField]
    GameObject Continue, SettingsPanel, Settings, soundOn, soundOff, direksiyonSag, direksiyonSol, EngineSteering, carSoundOn, carSoundOff;
    [SerializeField]
    AudioSource menu;
    int LeveltoContinue = 0;
    public static int sound = 0, carSound = 0;
    void ContinueAgainNoMoney()
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
    private void Start()
    {
        ContinueAgainNoMoney();
        if (PlayerPrefs.HasKey("sound"))
        {
            sound = PlayerPrefs.GetInt("sound");
        }
        if (PlayerPrefs.HasKey("carsound"))
        {
            carSound = PlayerPrefs.GetInt("carsound");
        }
        if (sound == 0)
        {
            menu.enabled = true;
            soundOn.SetActive(true);
            soundOff.SetActive(false);
            PlayerPrefs.SetInt("sound", sound);
        }
        else if (sound == 1)
        {
            menu.enabled = false;
            soundOn.SetActive(false);
            soundOff.SetActive(true);
            PlayerPrefs.SetInt("sound", sound);
        }
        if(carSound == 0)
        {
            carSoundOn.SetActive(true);
            carSoundOff.SetActive(false);
            PlayerPrefs.SetInt("carsound", carSound);
        }
        else if(carSound == 1)
        {
            carSoundOn.SetActive(false);
            carSoundOff.SetActive(true);
            PlayerPrefs.SetInt("carsound", carSound);
        }
        if (PlayerPrefs.HasKey("SagSol"))
        {
            ContinuePause.SagSol = PlayerPrefs.GetInt("SagSol");
        }
        if (ContinuePause.SagSol == 1)
        {
            direksiyonSag.SetActive(false);
            direksiyonSol.SetActive(true);
        }
        else if (ContinuePause.SagSol == 0)
        {
            direksiyonSag.SetActive(true);
            direksiyonSol.SetActive(false);
        }

        if (PlayerPrefs.HasKey("Level"))
        {
            LeveltoContinue = PlayerPrefs.GetInt("Level");
        }
    }
    public void Play()
    {
        MenuLevel.active = 0;
        if(LeveltoContinue == 0)
        {
            SceneManager.LoadScene("level1");
        }
        else
        {
            SceneManager.LoadScene(LeveltoContinue);
        }
    }
    public void settings()
    {
        EngineSteering.SetActive(false);
        SettingsPanel.SetActive(true);
        Continue.SetActive(false);
        Settings.SetActive(false);
    }
    public void BackSettings()
    {
        EngineSteering.SetActive(true);
        Settings.SetActive(true);
        Continue.SetActive(true);
        SettingsPanel.SetActive(false);
    }
    public void DireksiyonSag()
    {
        ContinuePause.SagSol = 1;
        direksiyonSag.SetActive(false);
        direksiyonSol.SetActive(true);
        PlayerPrefs.SetInt("SagSol", ContinuePause.SagSol);
    }
    public void DireksiyonSol()
    {
        ContinuePause.SagSol = 0;
        direksiyonSag.SetActive(true);
        direksiyonSol.SetActive(false);
        PlayerPrefs.SetInt("SagSol", ContinuePause.SagSol);
    }
    public void SoundOff()
    {
        sound = 0;
        menu.enabled = true;
        menu.Play();
        soundOn.SetActive(true);
        soundOff.SetActive(false);
        PlayerPrefs.SetInt("sound", sound);
    }
    public void SoundOn()
    {
        sound = 1;
        menu.enabled = false;
        soundOn.SetActive(false);
        soundOff.SetActive(true);
        PlayerPrefs.SetInt("sound",sound);
    }
    public void CarSoundOn()
    {
        carSound = 1;
        carSoundOn.SetActive(false);
        carSoundOff.SetActive(true);
        PlayerPrefs.SetInt("carsound", carSound);
    }
    public void CarSoundOff()
    {
        carSound = 0;
        carSoundOn.SetActive(true);
        carSoundOff.SetActive(false);
        PlayerPrefs.SetInt("carsound", carSound);
    }
}
