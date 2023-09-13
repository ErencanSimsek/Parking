using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiFiControl : MonoBehaviour
{
    bool wifibagla;
    [Header("Menu")]
    [SerializeField] GameObject Canvas, Menu, Button;

    [Header("Ses")]
    [SerializeField] AudioSource  menu, CarEngine;
    private void Start()
    {
        if (Application.internetReachability == NetworkReachability.NotReachable)
        {
            wifibagla = false;
        }
        else if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork ||
            Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
        {
            wifibagla = true;
        }
        wifi();
    }
    private void Update()
    {
        wifi();
    }
    void wifi()
    {
        if(Application.internetReachability == NetworkReachability.NotReachable)
        {
            if(wifibagla == false)
            {
                Time.timeScale = 0;
                Canvas.SetActive(false);
                Menu.SetActive(false);
                Button.SetActive(false);
                menu.enabled = false;
                CarEngine.enabled = false;
                wifibagla = true;
            }
        }
        
        else if(Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork || 
            Application.internetReachability == NetworkReachability.ReachableViaLocalAreaNetwork)
        {
            if (wifibagla == true)
            {
                Time.timeScale = 1;
                if (ContinuePause.bContinue == true)
                {
                    menuActive();
                }
                else if(AgainMenu.bAgain == true)
                {
                    menuActive();
                }
                else if (AgainMenu.bNoMoney == true)
                {
                    menuActive();
                }
                else
                {
                    Canvas.SetActive(true);
                    Menu.SetActive(true);
                    Button.SetActive(true);
                    if(AnaMenu.sound == 0)
                    {
                        menu.enabled = true;
                        if(move.Vites == "D" || move.Vites == "N" || move.Vites == "P")
                        {
                            CarEngine.enabled = true;
                        }
                        else if (move.Vites == "R")
                        {
                            CarEngine.enabled = true;
                            CarEngine.Stop();
                        }
                    }
                }
                wifibagla = false;
            }
        }
    }

    void menuActive()
    {
        if (AnaMenu.sound == 0)
        {
            menu.enabled = true;
            menu.Play();
            CarEngine.enabled = true;
            CarEngine.Stop();
            Menu.SetActive(true);
            Button.SetActive(true);
        }
    }
}
