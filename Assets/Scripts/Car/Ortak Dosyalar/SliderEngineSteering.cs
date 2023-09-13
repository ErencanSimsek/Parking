using GoogleMobileAds.Api;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderEngineSteering : MonoBehaviour
{
    [SerializeField] GameObject Panel;
    [SerializeField] Slider EngineSlider,SteeringSlider;
    [SerializeField] Text EngineText, SteeringText, MoneyText, CarBuyText, PanelText, YesText, NoText, OkeyText, EnginePlusText, SteeringPlusText;
    [SerializeField] Button EngineButton, SteeringButton, CarBuyButton, Continue, YesButton, NoButton, OkeyButton;
    int fiyat = 0;
    List<int> Buy = new List<int>();


    private void Start()
    {
        CarBuy();
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {
        });
        LoadRewardedAd();
        if (PlayerPrefs.HasKey("Buy[1]"))
        {
            Buy[1] = PlayerPrefs.GetInt("Buy[1]");
        }
        if (PlayerPrefs.HasKey("Buy[2]"))
        {
            //Buy[2] = PlayerPrefs.GetInt("Buy[2]");
        }
        if (PlayerPrefs.HasKey("money"))
        {
            //move.Money = PlayerPrefs.GetInt("money");
        }
        MoneyText.text = move.Money.ToString();
    }
    private void Update()
    {
        if(Araclar.aktif == 0) 
        {
            CarBuyButton.enabled = false;
            CarBuyButton.image.enabled = false;
            CarBuyText.enabled = false;
            if(Buy[0] == 1)
            {
                Continue.enabled = true;
                Continue.image.enabled = true;
                CarBuyButton.enabled = false;
                CarBuyButton.image.enabled = false;
                CarBuyText.enabled = false;
            }
            else if (Buy[0] == 0)
            {
                Continue.enabled = false;
                Continue.image.enabled = false;
                CarBuyButton.enabled = true;
                CarBuyButton.image.enabled = true;
                CarBuyText.enabled = true;
            }
            EngineSlider.value = Car1.SliderEngine;
            SteeringSlider.value = Car1.SliderSteering;
            EngineText.text = Car1.CarHiz.ToString();
            SteeringText.text = Car1.maksimumYonlendirme.ToString();
        }
        else if(Araclar.aktif == 1) 
        {
            if (Buy[1] == 1)
            {
                Continue.enabled = true;
                Continue.image.enabled = true;
                CarBuyButton.enabled = false;
                CarBuyButton.image.enabled = false;
                CarBuyText.enabled = false;
            }
            else if (Buy[1] == 0)
            {
                Continue.enabled = false;
                Continue.image.enabled = false;
                CarBuyButton.enabled = true;
                CarBuyButton.image.enabled = true;
                CarBuyText.enabled = true;
            }
            CarBuyText.text = "Watch";
            EngineSlider.value = Car2.SliderEngine;
            SteeringSlider.value = Car2.SliderSteering;
            EngineText.text = Car2.CarHiz.ToString();
            SteeringText.text = Car2.maksimumYonlendirme.ToString();
        }
        else if(Araclar.aktif == 2) 
        {
            if (Buy[2] == 1)
            {
                Continue.enabled = true;
                Continue.image.enabled = true;
                CarBuyButton.enabled = false;
                CarBuyButton.image.enabled = false;
                CarBuyText.enabled = false;
            }
            else if (Buy[2] == 0)
            {
                Continue.enabled = false;
                Continue.image.enabled = false;
                CarBuyButton.enabled = true;
                CarBuyButton.image.enabled = true;
                CarBuyText.enabled = true;
            }
            fiyat = 500;
            CarBuyText.text = fiyat + "$";
            EngineSlider.value = Car3.SliderEngine;
            SteeringSlider.value = Car3.SliderSteering;
            EngineText.text = Car3.CarHiz.ToString();
            SteeringText.text = Car3.maksimumYonlendirme.ToString();
        }

        if(Araclar.aktif == 0) 
        {
            if(Car1.CarHiz != 49 && Buy[0] == 1)
            {
                EngineButton.enabled = true;
                EngineButton.image.enabled = true;
                EnginePlusText.enabled = true;
            }
            else
            {
                EngineButton.enabled = false;
                EngineButton.image.enabled = false;
                EnginePlusText.enabled = false;
            }

            if (Car1.maksimumYonlendirme != 34 && Buy[0] == 1)
            {
                SteeringButton.enabled = true;
                SteeringButton.image.enabled = true;
                SteeringPlusText.enabled = true;
            }
            else
            {
                SteeringButton.enabled = false;
                SteeringButton.image.enabled = false;
                SteeringPlusText.enabled = false;
            }
        }
        else if(Araclar.aktif == 1) 
        {
            if (Car2.CarHiz != 54 && Buy[1] == 1)
            {
                EngineButton.enabled = true;
                EngineButton.image.enabled = true;
                EnginePlusText.enabled = true;
            }
            else
            {
                EngineButton.enabled = false;
                EngineButton.image.enabled = false;
                EnginePlusText.enabled = false;
            }

            if (Car2.maksimumYonlendirme != 39 && Buy[1] == 1)
            {
                SteeringButton.enabled = true;
                SteeringButton.image.enabled = true;
                SteeringPlusText.enabled = true;
            }
            else
            {
                SteeringButton.enabled = false;
                SteeringButton.image.enabled = false;
                SteeringPlusText.enabled = false;
            }
        }
        else if(Araclar.aktif == 2) 
        {
            if (Car3.CarHiz != 59 && Buy[2] == 1)
            {
                EngineButton.enabled = true;
                EngineButton.image.enabled = true;
                EnginePlusText.enabled = true;
            }
            else
            {
                EngineButton.enabled = false;
                EngineButton.image.enabled = false;
                EnginePlusText.enabled = false;
            }

            if (Car3.maksimumYonlendirme != 44 && Buy[2] == 1)
            {
                SteeringButton.enabled = true;
                SteeringButton.image.enabled = true;
                SteeringPlusText.enabled = true;
            }
            else
            {
                SteeringButton.enabled = false;
                SteeringButton.image.enabled = false;
                SteeringPlusText.enabled = false;
            }
        }

        PlayerPrefs.SetInt("money", move.Money);
    }

    public void CarBuyy()
    {
        if(Araclar.aktif == 1)
        {
            ShowRewardedAd();
        }
        if(move.Money >= fiyat && Araclar.aktif != 1)
        {
            Panel.SetActive(true);
            PanelText.text = "Will you buy this vehicle?";
            YesButton.enabled = true;
            YesButton.image.enabled = true;
            YesText.enabled = true;
            NoButton.enabled = true;
            NoButton.image.enabled = true;
            NoText.enabled = true;

            OkeyButton.enabled = false;
            OkeyButton.image.enabled = false;
            OkeyText.enabled = false;
        }
        else if (move.Money < fiyat && Araclar.aktif != 1)
        {
            Panel.SetActive(true);
            PanelText.text = "You don't have enough money";
            OkeyButton.enabled = true;
            OkeyButton.image.enabled = true;
            OkeyText.enabled = true;

            YesButton.enabled = false;
            YesButton.image.enabled = false;
            YesText.enabled = false;
            NoButton.enabled = false;
            NoButton.image.enabled = false;
            NoText.enabled = false;
        }
    }
    public void Yes()
    {
        Buy[Araclar.aktif] = 1;
        if(Araclar.aktif == 2)
        {
            Buy[2] = 1;
            PlayerPrefs.SetInt("Buy[2]", Buy[2]);
        }
        Panel.SetActive(false);
        move.Money -= fiyat;
        MoneyText.text = move.Money.ToString();
    }
    public void Okey()
    {
        Panel.SetActive(false);
    }
    private void CarBuy()
    {
        Buy.Add(1);
        Buy.Add(0);
        Buy.Add(0);
    }

    public void HizPlus()
    {
        if (Araclar.aktif == 0)
        {
            if(move.Money >= 300) 
            {
                Car1.CarHiz += 2;
                PlayerPrefs.SetFloat("Car1Hiz", Car1.CarHiz);
                Car1.SliderEngine += 0.5f;
                PlayerPrefs.SetFloat("Car1Slider", Car1.SliderEngine);
                move.Money -= 300;
                MoneyText.text = move.Money.ToString();
            }
            else if(move.Money < 300) 
            {
                Panel.SetActive(true);
                PanelText.text = "You don't have enough money";
                OkeyButton.enabled = true;
                OkeyButton.image.enabled = true;
                OkeyText.enabled = true;

                YesButton.enabled = false;
                YesButton.image.enabled = false;
                YesText.enabled = false;
                NoButton.enabled = false;
                NoButton.image.enabled = false;
                NoText.enabled = false;
                OkeyButton.onClick.AddListener(Okey);
            }
        }
        else if (Araclar.aktif == 1)
        {
            if (move.Money >= 300)
            {
                Car2.CarHiz += 2;
                PlayerPrefs.SetFloat("Car2Hiz", Car2.CarHiz);
                Car2.SliderEngine += 0.5f;
                PlayerPrefs.SetFloat("Car2Slider", Car2.SliderEngine);
                move.Money -= 300;
                MoneyText.text = move.Money.ToString();
            }
            else if (move.Money < 300)
            {
                Panel.SetActive(true);
                PanelText.text = "You don't have enough money";
                OkeyButton.enabled = true;
                OkeyButton.image.enabled = true;
                OkeyText.enabled = true;

                YesButton.enabled = false;
                YesButton.image.enabled = false;
                YesText.enabled = false;
                NoButton.enabled = false;
                NoButton.image.enabled = false;
                NoText.enabled = false;
                OkeyButton.onClick.AddListener(Okey);
            }
        }
        else if (Araclar.aktif == 2)
        {
            if (move.Money >= 300)
            {
                Car3.CarHiz += 2;
                PlayerPrefs.SetFloat("Car3Hiz", Car3.CarHiz);
                Car3.SliderEngine += 0.5f;
                PlayerPrefs.SetFloat("Car3Slider", Car3.SliderEngine);
                move.Money -= 300;
                MoneyText.text = move.Money.ToString();
            }
            else if (move.Money < 300)
            {
                Panel.SetActive(true);
                PanelText.text = "You don't have enough money";
                OkeyButton.enabled = true;
                OkeyButton.image.enabled = true;
                OkeyText.enabled = true;

                YesButton.enabled = false;
                YesButton.image.enabled = false;
                YesText.enabled = false;
                NoButton.enabled = false;
                NoButton.image.enabled = false;
                NoText.enabled = false;
                OkeyButton.onClick.AddListener(Okey);
            }
        }
    }
    public void YonlendirmePlus()
    {
        if (Araclar.aktif == 0)
        {
            if (move.Money >= 300)
            {
                Car1.maksimumYonlendirme += 2;
                PlayerPrefs.SetFloat("Car1Yonlendirme", Car1.maksimumYonlendirme);
                Car1.SliderSteering += 0.5f;
                PlayerPrefs.SetFloat("Car1SliderSteering", Car1.SliderSteering);
                move.Money -= 300;
                MoneyText.text = move.Money.ToString();
            }
            else if (move.Money < 300)
            {
                Panel.SetActive(true);
                PanelText.text = "You don't have enough money";
                OkeyButton.enabled = true;
                OkeyButton.image.enabled = true;
                OkeyText.enabled = true;

                YesButton.enabled = false;
                YesButton.image.enabled = false;
                YesText.enabled = false;
                NoButton.enabled = false;
                NoButton.image.enabled = false;
                NoText.enabled = false;
                OkeyButton.onClick.AddListener(Okey);
            }
        }
        else if (Araclar.aktif == 1)
        {
            if (move.Money >= 300)
            {
                Car2.maksimumYonlendirme += 2;
                PlayerPrefs.SetFloat("Car2Yonlendirme", Car2.maksimumYonlendirme);
                Car2.SliderSteering += 0.5f;
                PlayerPrefs.SetFloat("Car2SliderSteering", Car2.SliderSteering);
                move.Money -= 300;
                MoneyText.text = move.Money.ToString();
            }
            else if (move.Money < 300)
            {
                Panel.SetActive(true);
                PanelText.text = "You don't have enough money";
                OkeyButton.enabled = true;
                OkeyButton.image.enabled = true;
                OkeyText.enabled = true;

                YesButton.enabled = false;
                YesButton.image.enabled = false;
                YesText.enabled = false;
                NoButton.enabled = false;
                NoButton.image.enabled = false;
                NoText.enabled = false;
                OkeyButton.onClick.AddListener(Okey);
            }
        }
        else if (Araclar.aktif == 2)
        {
            if (move.Money >= 300)
            {
                Car3.maksimumYonlendirme += 2;
                PlayerPrefs.SetFloat("Car3Yonlendirme", Car3.maksimumYonlendirme);
                Car3.SliderSteering += 0.5f;
                PlayerPrefs.SetFloat("Car3SliderSteering", Car3.SliderSteering);
                move.Money -= 300;
                MoneyText.text = move.Money.ToString();
            }
            else if (move.Money < 300)
            {
                Panel.SetActive(true);
                PanelText.text = "You don't have enough money";
                OkeyButton.enabled = true;
                OkeyButton.image.enabled = true;
                OkeyText.enabled = true;

                YesButton.enabled = false;
                YesButton.image.enabled = false;
                YesText.enabled = false;
                NoButton.enabled = false;
                NoButton.image.enabled = false;
                NoText.enabled = false;
                OkeyButton.onClick.AddListener(Okey);
            }
        }
    }

#if UNITY_ANDROID
    private string _adUnitId = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
  private string _adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
  private string _adUnitId = "unused";
#endif

    private RewardedAd rewardedAd;
    public void LoadRewardedAd()
    {
        if (rewardedAd != null)
        {
            rewardedAd.Destroy();
            rewardedAd = null;
        }

        var adRequest = new AdRequest();
        adRequest.Keywords.Add("unity-admob-sample");

        RewardedAd.Load(_adUnitId, adRequest,
            (RewardedAd ad, LoadAdError error) =>
            {
                if (error != null || ad == null)
                {
                    Debug.LogError("Rewarded ad failed to load an ad " +
                                   "with error : " + error);
                    return;
                }
                rewardedAd = ad;
                RegisterReloadHandler(rewardedAd);
            });
    }
    void ShowRewardedAd()
    {
        const string rewardMsg =
            "Rewarded ad rewarded the user. Type: {0}, amount: {1}.";

        if (rewardedAd != null && rewardedAd.CanShowAd())
        {
            rewardedAd.Show((Reward reward) =>
            {
                Debug.Log(String.Format(rewardMsg, reward.Type, reward.Amount));
                Buy[1] = 1;
                PlayerPrefs.SetInt("Buy[1]", Buy[1]);

            });
        }
    }
    private void RegisterReloadHandler(RewardedAd ad)
    {
        ad.OnAdFullScreenContentClosed += () =>
        {
            LoadRewardedAd();
        };
        ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            LoadRewardedAd();
        };
    }
}
