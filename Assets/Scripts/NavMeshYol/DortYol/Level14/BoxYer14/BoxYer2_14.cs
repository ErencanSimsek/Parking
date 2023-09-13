using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxYer2_14 : MonoBehaviour
{
    public Transform Yer1, Yer2, Yer3;
    public static int son = 0;
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
            son = 1;
        }
    }
}
