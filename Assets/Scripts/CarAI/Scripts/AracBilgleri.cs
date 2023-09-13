using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AracBilgleri : MonoBehaviour
{
    RaycastHit hit;
    public static List<int> durum = new List<int>();
    public int aracindex, deger;
    public GameObject[] objects;
    private void Start()
    {
        durumlar();
    }
    void durumlar()
    {
        durum.Add(0);
        durum.Add(0);
        durum.Add(0);
        durum.Add(0);
        durum.Add(0);
        durum.Add(0);
        durum.Add(0);
        durum.Add(0);
        durum.Add(0);
        durum.Add(0);
        durum.Add(0);
        durum.Add(0);
        durum.Add(0);
        durum.Add(0);
        durum.Add(0);
        durum.Add(0);
        durum.Add(0);
    }
    private void FixedUpdate()
    {
        if (move.Money != 0)
        {
            if (aracindex == 0)
            {
                if (AgainMenu.bAgain == true || AgainMenu.bNoMoney == true)
                {
                    durum[0] = 1;
                    AracNoktalari.grup[deger] = 1;
                }
                else
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
                    {
                        durum[0] = 1;
                        AracNoktalari.grup[deger] = 1;
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                        if (hit.collider.CompareTag("NoWay") || hit.collider.CompareTag("Road1") || hit.collider.CompareTag("Road2") || hit.collider.CompareTag("Road3")
                                    || hit.collider.CompareTag("Road4") || hit.collider.CompareTag("Road5"))
                        {
                            durum[0] = 2;
                            AracNoktalari.grup[deger] = 0;
                        }
                        else if (hit.collider.CompareTag("Cars"))
                        {
                            durum[0] = 1;
                            AracNoktalari.grup[deger] = 1;
                            foreach (var item in objects)
                            {
                                item.SetActive(false);
                            }
                        }
                    }
                    else
                    {
                        AracNoktalari.grup[deger] = 0;
                        foreach (var item in objects)
                        {
                            item.SetActive(true);
                        }
                        if (AracNoktalari.grup[0] == 0 && AracNoktalari.grup[1] == 0 && AracNoktalari.grup[2] == 0)
                        {
                            durum[0] = 2;
                            foreach (var item in objects)
                            {
                                item.SetActive(true);
                            }
                        }
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                    }
                }
            }
            else if (aracindex == 1)
            {
                if (AgainMenu.bAgain == true || AgainMenu.bNoMoney == true)
                {
                    durum[1] = 1;
                    AracNoktalari.grup[deger] = 1;
                }
                else
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
                    {
                        durum[1] = 1;
                        AracNoktalari.grup[deger] = 1;
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                        if (hit.collider.CompareTag("NoWay") || hit.collider.CompareTag("Road1") || hit.collider.CompareTag("Road2") || hit.collider.CompareTag("Road3")
                                    || hit.collider.CompareTag("Road4") || hit.collider.CompareTag("Road5"))
                        {
                            durum[1] = 2;
                            AracNoktalari.grup[deger] = 0;
                        }
                        else if (hit.collider.CompareTag("Cars"))
                        {
                            durum[1] = 1;
                            AracNoktalari.grup[deger] = 1;
                            foreach (var item in objects)
                            {
                                item.SetActive(false);
                            }
                        }
                    }
                    else
                    {
                        AracNoktalari.grup[deger] = 0;
                        foreach (var item in objects)
                        {
                            item.SetActive(true);
                        }
                        if (AracNoktalari.grup[0] == 0 && AracNoktalari.grup[1] == 0 && AracNoktalari.grup[2] == 0)
                        {
                            durum[1] = 2;
                            foreach (var item in objects)
                            {
                                item.SetActive(true);
                            }
                        }
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                    }
                }
            }
            else if (aracindex == 4)
            {
                if(AgainMenu.bAgain == true || AgainMenu.bNoMoney == true)
                {
                    durum[2] = 1;
                    AracNoktalari.grup[deger] = 1;
                }
                else
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
                    {
                        durum[2] = 1;
                        AracNoktalari.grup[deger] = 1;
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                        if (hit.collider.CompareTag("NoWay") || hit.collider.CompareTag("Road1") || hit.collider.CompareTag("Road2") || hit.collider.CompareTag("Road3")
                                    || hit.collider.CompareTag("Road4") || hit.collider.CompareTag("Road5"))
                        {
                            durum[2] = 2;
                            AracNoktalari.grup[deger] = 0;
                        }
                        else if (hit.collider.CompareTag("Cars"))
                        {
                            durum[2] = 1;
                            AracNoktalari.grup[deger] = 1;
                            foreach (var item in objects)
                            {
                                item.SetActive(false);
                            }
                        }
                    }
                    else
                    {
                        AracNoktalari.grup[deger] = 0;
                        foreach (var item in objects)
                        {
                            item.SetActive(true);
                        }
                        if (AracNoktalari.grup[0] == 0 && AracNoktalari.grup[1] == 0 && AracNoktalari.grup[2] == 0)
                        {
                            durum[2] = 2;
                            foreach (var item in objects)
                            {
                                item.SetActive(true);
                            }
                        }
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                    }
                }
                
            }
            else if (aracindex == 3)
            {
                if (AgainMenu.bAgain == true || AgainMenu.bNoMoney == true)
                {
                    durum[3] = 1;
                    AracNoktalari.grup[deger] = 1;
                }
                else
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
                    {
                        durum[3] = 1;
                        AracNoktalari.grup[deger] = 1;
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                        if (hit.collider.CompareTag("NoWay") || hit.collider.CompareTag("Road1") || hit.collider.CompareTag("Road2") || hit.collider.CompareTag("Road3")
                                    || hit.collider.CompareTag("Road4") || hit.collider.CompareTag("Road5"))
                        {
                            durum[3] = 2;
                            AracNoktalari.grup[deger] = 0;
                        }
                        else if (hit.collider.CompareTag("Cars"))
                        {
                            durum[3] = 1;
                            AracNoktalari.grup[deger] = 1;
                            foreach (var item in objects)
                            {
                                item.SetActive(false);
                            }
                        }
                    }
                    else
                    {
                        AracNoktalari.grup[deger] = 0;
                        foreach (var item in objects)
                        {
                            item.SetActive(true);
                        }
                        if (AracNoktalari.grup[0] == 0 && AracNoktalari.grup[1] == 0 && AracNoktalari.grup[2] == 0)
                        {
                            durum[3] = 2;
                            foreach (var item in objects)
                            {
                                item.SetActive(true);
                            }
                        }
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                    }
                }
            }
            else if (aracindex == 2)
            {
                if (AgainMenu.bAgain == true || AgainMenu.bNoMoney == true)
                {
                    durum[4] = 1;
                    AracNoktalari.grup[deger] = 1;
                }
                else
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
                    {
                        durum[4] = 1;
                        AracNoktalari.grup[deger] = 1;
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                        if (hit.collider.CompareTag("NoWay") || hit.collider.CompareTag("Road1") || hit.collider.CompareTag("Road2") || hit.collider.CompareTag("Road3")
                                    || hit.collider.CompareTag("Road4") || hit.collider.CompareTag("Road5"))
                        {
                            durum[4] = 2;
                            AracNoktalari.grup[deger] = 0;
                        }
                        else if (hit.collider.CompareTag("Cars"))
                        {
                            
                            durum[4] = 1;
                            AracNoktalari.grup[deger] = 1;
                            foreach (var item in objects)
                            {
                                item.SetActive(false);
                            }
                        }
                    }
                    else
                    {
                        AracNoktalari.grup[deger] = 0;
                        foreach (var item in objects)
                        {
                            item.SetActive(true);
                        }
                        if (AracNoktalari.grup[0] == 0 && AracNoktalari.grup[1] == 0 && AracNoktalari.grup[2] == 0)
                        {
                            durum[4] = 2;
                            foreach (var item in objects)
                            {
                                item.SetActive(true);
                            }
                        }
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                    }
                }
            }
            else if (aracindex == 5)
            {
                if (AgainMenu.bAgain == true || AgainMenu.bNoMoney == true)
                {
                    durum[5] = 1;
                    AracNoktalari.grup[deger] = 1;
                }
                else
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
                    {
                        durum[5] = 1;
                        AracNoktalari.grup[deger] = 1;
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                        if (hit.collider.CompareTag("NoWay") || hit.collider.CompareTag("Road1") || hit.collider.CompareTag("Road2") || hit.collider.CompareTag("Road3")
                                    || hit.collider.CompareTag("Road4") || hit.collider.CompareTag("Road5"))
                        {
                            durum[5] = 2;
                            AracNoktalari.grup[deger] = 0;
                        }
                        else if (hit.collider.CompareTag("Cars"))
                        {
                            durum[5] = 1;
                            AracNoktalari.grup[deger] = 1;
                            foreach (var item in objects)
                            {
                                item.SetActive(false);
                            }
                        }
                    }
                    else
                    {
                        AracNoktalari.grup[deger] = 0;
                        foreach (var item in objects)
                        {
                            item.SetActive(true);
                        }
                        if (AracNoktalari.grup[0] == 0 && AracNoktalari.grup[1] == 0 && AracNoktalari.grup[2] == 0)
                        {
                            durum[5] = 2;
                            foreach (var item in objects)
                            {
                                item.SetActive(true);
                            }
                        }
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                    }
                }
            }
            else if (aracindex == 6)
            {
                if (AgainMenu.bAgain == true || AgainMenu.bNoMoney == true)
                {
                    durum[6] = 1;
                    AracNoktalari.grup[deger] = 1;
                }
                else
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
                    {
                        durum[6] = 1;
                        AracNoktalari.grup[deger] = 1;
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                        if (hit.collider.CompareTag("NoWay") || hit.collider.CompareTag("Road1") || hit.collider.CompareTag("Road2") || hit.collider.CompareTag("Road3")
                                    || hit.collider.CompareTag("Road4") || hit.collider.CompareTag("Road5"))
                        {
                            durum[6] = 2;
                            AracNoktalari.grup[deger] = 0;
                        }
                        else if (hit.collider.CompareTag("Cars"))
                        {
                            durum[6] = 1;
                            AracNoktalari.grup[deger] = 1;
                            foreach (var item in objects)
                            {
                                item.SetActive(false);
                            }
                        }
                    }
                    else
                    {
                        AracNoktalari.grup[deger] = 0;
                        foreach (var item in objects)
                        {
                            item.SetActive(true);
                        }
                        if (AracNoktalari.grup[0] == 0 && AracNoktalari.grup[1] == 0 && AracNoktalari.grup[2] == 0)
                        {
                            durum[6] = 2;
                            foreach (var item in objects)
                            {
                                item.SetActive(true);
                            }
                        }
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                    }
                }
            }
            else if (aracindex == 7)
            {
                if (AgainMenu.bAgain == true || AgainMenu.bNoMoney == true)
                {
                    durum[7] = 1;
                    AracNoktalari.grup[deger] = 1;
                }
                else
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
                    {
                        durum[7] = 1;
                        AracNoktalari.grup[deger] = 1;
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                        if (hit.collider.CompareTag("NoWay") || hit.collider.CompareTag("Road1") || hit.collider.CompareTag("Road2") || hit.collider.CompareTag("Road3")
                                    || hit.collider.CompareTag("Road4") || hit.collider.CompareTag("Road5"))
                        {
                            durum[7] = 2;
                            AracNoktalari.grup[deger] = 0;
                        }
                        else if (hit.collider.CompareTag("Cars"))
                        {
                            durum[7] = 1;
                            AracNoktalari.grup[deger] = 1;
                            foreach (var item in objects)
                            {
                                item.SetActive(false);
                            }
                        }
                    }
                    else
                    {
                        AracNoktalari.grup[deger] = 0;
                        foreach (var item in objects)
                        {
                            item.SetActive(true);
                        }
                        if (AracNoktalari.grup[0] == 0 && AracNoktalari.grup[1] == 0 && AracNoktalari.grup[2] == 0)
                        {
                            durum[7] = 2;
                            foreach (var item in objects)
                            {
                                item.SetActive(true);
                            }
                        }
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                    }
                }
            }
            else if (aracindex == 8)
            {
                if (AgainMenu.bAgain == true || AgainMenu.bNoMoney == true)
                {
                    durum[8] = 1;
                    AracNoktalari.grup[deger] = 1;
                }
                else
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
                    {
                        durum[8] = 1;
                        AracNoktalari.grup[deger] = 1;
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                        if (hit.collider.CompareTag("NoWay") || hit.collider.CompareTag("Road1") || hit.collider.CompareTag("Road2") || hit.collider.CompareTag("Road3")
                                    || hit.collider.CompareTag("Road4") || hit.collider.CompareTag("Road5"))
                        {
                            durum[8] = 2;
                            AracNoktalari.grup[deger] = 0;
                        }
                        else if (hit.collider.CompareTag("Cars"))
                        {
                            durum[8] = 1;
                            AracNoktalari.grup[deger] = 1;
                            foreach (var item in objects)
                            {
                                item.SetActive(false);
                            }
                        }
                    }
                    else
                    {
                        AracNoktalari.grup[deger] = 0;
                        foreach (var item in objects)
                        {
                            item.SetActive(true);
                        }
                        if (AracNoktalari.grup[0] == 0 && AracNoktalari.grup[1] == 0 && AracNoktalari.grup[2] == 0)
                        {
                            durum[8] = 2;
                            foreach (var item in objects)
                            {
                                item.SetActive(true);
                            }
                        }
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                    }
                }
            }
            else if (aracindex == 9)
            {
                if (AgainMenu.bAgain == true || AgainMenu.bNoMoney == true)
                {
                    durum[9] = 1;
                    AracNoktalari.grup[deger] = 1;
                }
                else
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
                    {
                        durum[9] = 1;
                        AracNoktalari.grup[deger] = 1;
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                        if (hit.collider.CompareTag("NoWay") || hit.collider.CompareTag("Road1") || hit.collider.CompareTag("Road2") || hit.collider.CompareTag("Road3")
                                    || hit.collider.CompareTag("Road4") || hit.collider.CompareTag("Road5"))
                        {
                            durum[9] = 2;
                            AracNoktalari.grup[deger] = 0;
                        }
                        else if (hit.collider.CompareTag("Cars"))
                        {
                            durum[9] = 1;
                            AracNoktalari.grup[deger] = 1;
                            foreach (var item in objects)
                            {
                                item.SetActive(false);
                            }
                        }
                    }
                    else
                    {
                        AracNoktalari.grup[deger] = 0;
                        foreach (var item in objects)
                        {
                            item.SetActive(true);
                        }
                        if (AracNoktalari.grup[0] == 0 && AracNoktalari.grup[1] == 0 && AracNoktalari.grup[2] == 0)
                        {
                            durum[9] = 2;
                            foreach (var item in objects)
                            {
                                item.SetActive(true);
                            }
                        }
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                    }
                }
            }
            else if (aracindex == 10)
            {
                if (AgainMenu.bAgain == true || AgainMenu.bNoMoney == true)
                {
                    durum[10] = 1;
                    AracNoktalari.grup[deger] = 1;
                }
                else
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
                    {
                        durum[10] = 1;
                        AracNoktalari.grup[deger] = 1;
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                        if (hit.collider.CompareTag("NoWay") || hit.collider.CompareTag("Road1") || hit.collider.CompareTag("Road2") || hit.collider.CompareTag("Road3")
                                    || hit.collider.CompareTag("Road4") || hit.collider.CompareTag("Road5"))
                        {
                            durum[10] = 2;
                            AracNoktalari.grup[deger] = 0;
                        }
                        else if (hit.collider.CompareTag("Cars"))
                        {
                            durum[10] = 1;
                            AracNoktalari.grup[deger] = 1;
                            foreach (var item in objects)
                            {
                                item.SetActive(false);
                            }
                        }
                    }
                    else
                    {
                        AracNoktalari.grup[deger] = 0;
                        foreach (var item in objects)
                        {
                            item.SetActive(true);
                        }
                        if (AracNoktalari.grup[0] == 0 && AracNoktalari.grup[1] == 0 && AracNoktalari.grup[2] == 0)
                        {
                            durum[10] = 2;
                            foreach (var item in objects)
                            {
                                item.SetActive(true);
                            }
                        }
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                    }
                }
            }
            else if (aracindex == 11)
            {
                if (AgainMenu.bAgain == true || AgainMenu.bNoMoney == true)
                {
                    durum[11] = 1;
                    AracNoktalari.grup[deger] = 1;
                }
                else
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
                    {
                        durum[11] = 1;
                        AracNoktalari.grup[deger] = 1;
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                        if (hit.collider.CompareTag("NoWay") || hit.collider.CompareTag("Road1") || hit.collider.CompareTag("Road2") || hit.collider.CompareTag("Road3")
                                    || hit.collider.CompareTag("Road4") || hit.collider.CompareTag("Road5"))
                        {
                            durum[11] = 2;
                            AracNoktalari.grup[deger] = 0;
                        }
                        else if (hit.collider.CompareTag("Cars"))
                        {
                            durum[11] = 1;
                            AracNoktalari.grup[deger] = 1;
                            foreach (var item in objects)
                            {
                                item.SetActive(false);
                            }
                        }
                    }
                    else
                    {
                        AracNoktalari.grup[deger] = 0;
                        foreach (var item in objects)
                        {
                            item.SetActive(true);
                        }
                        if (AracNoktalari.grup[0] == 0 && AracNoktalari.grup[1] == 0 && AracNoktalari.grup[2] == 0)
                        {
                            durum[11] = 2;
                            foreach (var item in objects)
                            {
                                item.SetActive(true);
                            }
                        }
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                    }
                }
            }
            else if (aracindex == 12)
            {
                if (AgainMenu.bAgain == true || AgainMenu.bNoMoney == true)
                {
                    durum[12] = 1;
                    AracNoktalari.grup[deger] = 1;
                }
                else
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
                    {
                        durum[12] = 1;
                        AracNoktalari.grup[deger] = 1;
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                        if (hit.collider.CompareTag("NoWay") || hit.collider.CompareTag("Road1") || hit.collider.CompareTag("Road2") || hit.collider.CompareTag("Road3")
                                    || hit.collider.CompareTag("Road4") || hit.collider.CompareTag("Road5"))
                        {
                            durum[12] = 2;
                            AracNoktalari.grup[deger] = 0;
                        }
                        else if (hit.collider.CompareTag("Cars"))
                        {
                            durum[12] = 1;
                            AracNoktalari.grup[deger] = 1;
                            foreach (var item in objects)
                            {
                                item.SetActive(false);
                            }
                        }
                    }
                    else
                    {
                        AracNoktalari.grup[deger] = 0;
                        foreach (var item in objects)
                        {
                            item.SetActive(true);
                        }
                        if (AracNoktalari.grup[0] == 0 && AracNoktalari.grup[1] == 0 && AracNoktalari.grup[2] == 0)
                        {
                            durum[12] = 2;
                            foreach (var item in objects)
                            {
                                item.SetActive(true);
                            }
                        }
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                    }
                }
            }
            else if (aracindex == 13)
            {

                if (AgainMenu.bAgain == true || AgainMenu.bNoMoney == true)
                {
                    durum[13] = 1;
                    AracNoktalari.grup[deger] = 1;
                }
                else
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
                    {
                        durum[13] = 1;
                        AracNoktalari.grup[deger] = 1;
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                        if (hit.collider.CompareTag("NoWay") || hit.collider.CompareTag("Road1") || hit.collider.CompareTag("Road2") || hit.collider.CompareTag("Road3")
                                    || hit.collider.CompareTag("Road4") || hit.collider.CompareTag("Road5"))
                        {
                            durum[13] = 2;
                            AracNoktalari.grup[deger] = 0;
                        }
                        else if (hit.collider.CompareTag("Cars"))
                        {
                            durum[13] = 1;
                            AracNoktalari.grup[deger] = 1;
                            foreach (var item in objects)
                            {
                                item.SetActive(false);
                            }
                        }
                    }
                    else
                    {
                        AracNoktalari.grup[deger] = 0;
                        foreach (var item in objects)
                        {
                            item.SetActive(true);
                        }
                        if (AracNoktalari.grup[0] == 0 && AracNoktalari.grup[1] == 0 && AracNoktalari.grup[2] == 0)
                        {
                            durum[13] = 2;
                            foreach (var item in objects)
                            {
                                item.SetActive(true);
                            }
                        }
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                    }
                }
            }
            else if (aracindex == 14)
            {
                if (AgainMenu.bAgain == true || AgainMenu.bNoMoney == true)
                {
                    durum[14] = 1;
                    AracNoktalari.grup[deger] = 1;
                }
                else
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
                    {
                        durum[14] = 1;
                        AracNoktalari.grup[deger] = 1;
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                        if (hit.collider.CompareTag("NoWay") || hit.collider.CompareTag("Road1") || hit.collider.CompareTag("Road2") || hit.collider.CompareTag("Road3")
                                    || hit.collider.CompareTag("Road4") || hit.collider.CompareTag("Road5"))
                        {
                            durum[14] = 2;
                            AracNoktalari.grup[deger] = 0;
                        }
                        else if (hit.collider.CompareTag("Cars"))
                        {
                            durum[14] = 1;
                            AracNoktalari.grup[deger] = 1;
                            foreach (var item in objects)
                            {
                                item.SetActive(false);
                            }
                        }
                    }
                    else
                    {
                        AracNoktalari.grup[deger] = 0;
                        foreach (var item in objects)
                        {
                            item.SetActive(true);
                        }
                        if (AracNoktalari.grup[0] == 0 && AracNoktalari.grup[1] == 0 && AracNoktalari.grup[2] == 0)
                        {
                            durum[14] = 2;
                            foreach (var item in objects)
                            {
                                item.SetActive(true);
                            }
                        }
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                    }
                }
            }
            else if (aracindex == 15)
            {
                if (AgainMenu.bAgain == true || AgainMenu.bNoMoney == true)
                {
                    durum[15] = 1;
                    AracNoktalari.grup[deger] = 1;
                }
                else
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
                    {
                        durum[15] = 1;
                        AracNoktalari.grup[deger] = 1;
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                        if (hit.collider.CompareTag("NoWay") || hit.collider.CompareTag("Road1") || hit.collider.CompareTag("Road2") || hit.collider.CompareTag("Road3")
                                    || hit.collider.CompareTag("Road4") || hit.collider.CompareTag("Road5"))
                        {
                            durum[15] = 2;
                            AracNoktalari.grup[deger] = 0;
                        }
                        else if (hit.collider.CompareTag("Cars"))
                        {
                            durum[15] = 1;
                            AracNoktalari.grup[deger] = 1;
                            foreach (var item in objects)
                            {
                                item.SetActive(false);
                            }
                        }
                    }
                    else
                    {
                        AracNoktalari.grup[deger] = 0;
                        foreach (var item in objects)
                        {
                            item.SetActive(true);
                        }
                        if (AracNoktalari.grup[0] == 0 && AracNoktalari.grup[1] == 0 && AracNoktalari.grup[2] == 0)
                        {
                            durum[15] = 2;
                            foreach (var item in objects)
                            {
                                item.SetActive(true);
                            }
                        }
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                    }
                }
            }
            else if (aracindex == 16)
            {
                if (AgainMenu.bAgain == true || AgainMenu.bNoMoney == true)
                {
                    durum[16] = 1;
                    AracNoktalari.grup[deger] = 1;
                }
                else
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
                    {
                        durum[16] = 1;
                        AracNoktalari.grup[deger] = 1;
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                        if (hit.collider.CompareTag("NoWay") || hit.collider.CompareTag("Road1") || hit.collider.CompareTag("Road2") || hit.collider.CompareTag("Road3")
                                    || hit.collider.CompareTag("Road4") || hit.collider.CompareTag("Road5"))
                        {
                            durum[16] = 2;
                            AracNoktalari.grup[deger] = 0;
                        }
                        else if (hit.collider.CompareTag("Cars"))
                        {
                            durum[16] = 1;
                            AracNoktalari.grup[deger] = 1;
                            foreach (var item in objects)
                            {
                                item.SetActive(false);
                            }
                        }
                    }
                    else
                    {
                        AracNoktalari.grup[deger] = 0;
                        foreach (var item in objects)
                        {
                            item.SetActive(true);
                        }
                        if (AracNoktalari.grup[0] == 0 && AracNoktalari.grup[1] == 0 && AracNoktalari.grup[2] == 0)
                        {
                            durum[16] = 2;
                            foreach (var item in objects)
                            {
                                item.SetActive(true);
                            }
                        }
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
                    }
                }
            }
            else if (aracindex == 17)
            {
                if (AgainMenu.bAgain == true || AgainMenu.bNoMoney == true)
                {
                    durum[17] = 1;
                    AracNoktalari.grup[deger] = 1;
                }
                else
                {
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2))
                    {
                        durum[17] = 1;
                        AracNoktalari.grup[deger] = 1;
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
                        if (hit.collider.CompareTag("NoWay") || hit.collider.CompareTag("Road1") || hit.collider.CompareTag("Road2") || hit.collider.CompareTag("Road3")
                                    || hit.collider.CompareTag("Road4") || hit.collider.CompareTag("Road5"))
                        {
                            durum[17] = 2;
                            AracNoktalari.grup[deger] = 0;
                        }
                        else if (hit.collider.CompareTag("Cars"))
                        {
                            durum[17] = 1;
                            AracNoktalari.grup[deger] = 1;
                            foreach (var item in objects)
                            {
                                item.SetActive(false);
                            }
                        }
                    }
                    else
                    {
                        AracNoktalari.grup[deger] = 0;
                        foreach (var item in objects)
                        {
                            item.SetActive(true);
                        }
                        if (AracNoktalari.grup[0] == 0 && AracNoktalari.grup[1] == 0 && AracNoktalari.grup[2] == 0)
                        {
                            durum[17] = 2;
                            foreach (var item in objects)
                            {
                                item.SetActive(true);
                            }
                        }
                        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.black);
                    }
                }
            }
        }
        if (ContinuePause.menusesi == true)
        {
            durum[1] = 1;
            durum[2] = 1;
            durum[3] = 1;
            durum[4] = 1;
            durum[5] = 1;
            durum[6] = 1;
            durum[7] = 1;
            durum[8] = 1;
            durum[9] = 1;
            durum[10] = 1;
            durum[11] = 1;
            durum[12] = 1;
            durum[13] = 1;
            durum[14] = 1;
            durum[15] = 1;
            durum[16] = 1;
            durum[17] = 1;
            AracNoktalari.grup[deger] = 1;
        }
    }
}
