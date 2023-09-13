using GoogleMobileAds;
using GoogleMobileAds.Api;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RewardedAds : MonoBehaviour
{
    public void Start()
    {
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {
        });
        LoadRewardedAd();
    }
#if UNITY_ANDROID
    private string _adUnitId = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
  private string _adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
  private string _adUnitId = "unused";
#endif

    private RewardedAd rewardedAd;
    public static bool moneyyMenuu = false;
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
                    return;
                }
                rewardedAd = ad;
                RegisterReloadHandler(rewardedAd);
            });
    }
    public void ShowRewardedAd()
    {
        const string rewardMsg =
            "Rewarded ad rewarded the user. Type: {0}, amount: {1}.";

        if (rewardedAd != null && rewardedAd.CanShowAd())
        {
            moneyyMenuu = true;
            rewardedAd.Show((Reward reward) =>
            {
                Debug.Log(String.Format(rewardMsg, reward.Type, reward.Amount));
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
                moneyyMenuu = false;
            });
        }
    }
    private void RegisterReloadHandler(RewardedAd ad)
    {
        ad.OnAdFullScreenContentClosed += ()=>
        {
            LoadRewardedAd();
        };
        ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            LoadRewardedAd();
        };
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
