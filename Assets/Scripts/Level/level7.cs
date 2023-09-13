using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class level7 : MonoBehaviour
{
    [SerializeField] Image kilit;
    [SerializeField] Button ileri;
    public static bool ContinueAgainNoMoney = false;
    private void Start()
    {
        if (PlayerPrefs.HasKey("7 gecis"))
        {
            Gecis();
        }
    }
    private void Update()
    {
        if (parkYeri.Park == 4 && move.Vites == "P")
        {
            Gecis();
            PlayerPrefs.SetString("7 gecis", "7 gecis");
        }
        if (move.Money != 0)
        {
            if (ContinueAgainNoMoney == true && PlayerPrefs.HasKey("7 gecis"))
            {
                Gecis();
            }
            else if (ContinueAgainNoMoney == true)
            {
                kilit.enabled = true;
                if (ContinuePause.set == 1)
                {
                    kilit.enabled = true;
                }
                else if (ContinuePause.set == 2)
                {
                    kilit.enabled = false;
                }
                ileri.enabled = false;
                ileri.image.enabled = false;
            }
            else if (ContinueAgainNoMoney == false)
            {
                kilit.enabled = false;
                ileri.enabled = false;
                ileri.image.enabled = false;
            }
        }
    }

    void Gecis()
    {
        if (move.Money != 0)
        {
            kilit.enabled = false;
            ileri.enabled = true;
            ileri.image.enabled = true;
        }
    }
}
