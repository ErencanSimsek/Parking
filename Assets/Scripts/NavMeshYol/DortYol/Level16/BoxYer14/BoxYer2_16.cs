using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxYer2_16 : MonoBehaviour
{
    public Transform Yer1, Yer2, Yer3, Yer4, Yer5;
    public static int son = 0, numbar;
    public static string Name;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Road1"))
        {
            gameObject.GetComponent<CarAI>().CustomDestination = Yer2;
        }
        else if (other.gameObject.CompareTag("Road2"))
        {
            gameObject.GetComponent<CarAI>().CustomDestination = Yer3;
        }
        else if (other.gameObject.CompareTag("Road3"))
        {
            gameObject.GetComponent<CarAI>().CustomDestination = Yer4;
        }
        else if (other.gameObject.CompareTag("Road4"))
        {
            gameObject.GetComponent<CarAI>().CustomDestination = Yer5;
        }
        else if (other.gameObject.CompareTag("Road5"))
        {
            son = 1;
            Name = gameObject.name;
            numbar = int.Parse(gameObject.tag);
        }
    }
}
