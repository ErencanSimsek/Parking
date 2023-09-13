using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoneyMenu : MonoBehaviour
{
    [SerializeField]
    Text secondText, minuteText;
    [SerializeField] GameObject Canvas, NoMoney;

    float second = 15;
    int minute = 10;
    void Start()
    {
        if (PlayerPrefs.HasKey("second"))
        {
            second = PlayerPrefs.GetFloat("second");
        }
        if (PlayerPrefs.HasKey("minute"))
        {
            minute = PlayerPrefs.GetInt("minute");
        }
        if(minute < 10)
        {
            minuteText.text = "0" + minute;
        }
        if (minute >= 10)
        {
            minuteText.text = minute.ToString();
        }
        else if (minute < 10)
        {
            minuteText.text = "0" + minute;
        }
        secondText.text = (int)second + "";
        timeFunction();
    }

    void FixedUpdate()
    {
        timeFunction();
    }

    void timeFunction()
    {
        if(move.Money <= 0 && RewardedAds.moneyyMenuu == false)
        {
            second -= Time.unscaledDeltaTime;
            if (second >= 10)
            {
                secondText.text = (int)second + "";
            }
            else if(second < 10)
            {
                secondText.text = "0" + (int)second;
            }
            PlayerPrefs.SetFloat("second", second);
            if (second <= 0)
            {
                minute -= 1;
                if(minute != -1)
                {
                    if(minute >= 10)
                    {
                        minuteText.text = minute.ToString();
                    }
                    else if(minute < 10)
                    {
                        minuteText.text = "0" + minute;
                    }
                }
                else if(minute == -1)
                {
                    minuteText.text = "00";
                }
                PlayerPrefs.SetInt("minute", minute);
                if (minute != -1)
                {
                    second = 60;
                }
                else if (minute == -1)
                {
                    ContinueAgainNoMoney();
                    move.Money = 20;
                    Time.timeScale = 1;
                    PlayerPrefs.SetInt("Money", move.Money);
                    PlayerPrefs.DeleteKey("second");
                    PlayerPrefs.DeleteKey("minute");
                    Scene scene;
                    scene = SceneManager.GetActiveScene();
                    SceneManager.LoadScene(scene.name);
                    AgainMenu.bNoMoney = false;
                    AgainMenu.bAgain = false;
                    move.Gas = false;
                    MenuLevel.active = 0;
                    PlayerPrefs.DeleteKey("levelreklam");
                    PlayerPrefs.DeleteKey("yanmareklam");
                    parkYeri.Park = 0;
                }
            }
        }
    }

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
}
