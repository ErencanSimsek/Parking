using GoogleMobileAds;
using GoogleMobileAds.Api;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class interstitialAds : MonoBehaviour
{
    InterstitialAd interstitialAd;
    int level = 0, yanma = 0;
    int bolumgecis = 0;

    void Start()
    {
        if (PlayerPrefs.HasKey("levelreklam"))
        {
            level=PlayerPrefs.GetInt("levelreklam");
        }
        if (PlayerPrefs.HasKey("yanmareklam"))
        {
            yanma = PlayerPrefs.GetInt("yanmareklam");
        }
        MobileAds.Initialize((InitializationStatus initStatus) =>
        {
        });
        LoadInterstitialAd();
    }

#if UNITY_ANDROID
    private string _adUnitId = "ca-app-pub-3940256099942544/1033173712";
#elif UNITY_IPHONE
  private string _adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
  private string _adUnitId = "unused";
#endif

    void LoadInterstitialAd()
    {
        if (interstitialAd != null)
        {
            interstitialAd.Destroy();
            interstitialAd = null;
        }

        var adRequest = new AdRequest();
        adRequest.Keywords.Add("unity-admob-sample");

        InterstitialAd.Load(_adUnitId, adRequest,
            (InterstitialAd ad, LoadAdError error) =>
            {
                if (error != null || ad == null)
                {
                    return;
                }
                interstitialAd = ad;
                ReklamOlaylari(interstitialAd);
            });
    }

    void ReklamOlaylari(InterstitialAd ad)
    {
        ad.OnAdFullScreenContentClosed += () =>
        {
            if(yanma == 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                PlayerPrefs.DeleteKey("levelreklam");
                PlayerPrefs.DeleteKey("yanmareklam");
            }
            if (level == 2 && bolumgecis == 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                PlayerPrefs.DeleteKey("levelreklam");
                PlayerPrefs.DeleteKey("yanmareklam");
                bolumgecis = 0;
            }
            parkYeri.Park = 0;
            MenuLevel.active = 0;
            LoadInterstitialAd();
        };
        ad.OnAdFullScreenContentFailed += (AdError error) =>
        {
            LoadInterstitialAd();
        };
    }

    public void ShowAd()
    {
        if (level != 2)
        {
            level += 1;
            PlayerPrefs.SetInt("levelreklam", level);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            parkYeri.Park = 0;
            MenuLevel.active = 0;
        }
        else if (level == 2)
        {
            bolumgecis = 1;
            ads();
        }
    }
    void ads()
    {
        if (interstitialAd != null && interstitialAd.CanShowAd())
        {
            interstitialAd.Show();
        }
    }

    public void Again()
    {
        ContinuePause.bContinue = false;
        move.Gas = false;
        MenuLevel.active = 0;
        AgainMenu.bAgain = false;
        Time.timeScale = 1;
        parkYeri.Park = 0;
        continueagainnomoney();
        if (yanma != 3)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            yanma += 1;
            PlayerPrefs.SetInt("yanmareklam", yanma);
        }
        else if(yanma == 3)
        {
            ads();
        }
    }

    void continueagainnomoney()
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
