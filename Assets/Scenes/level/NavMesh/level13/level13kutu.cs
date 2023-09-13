using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level13kutu : MonoBehaviour
{
    [SerializeField] GameObject Yer1, Yer2, Yer3, Yer4;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Road1"))
        {
            gameObject.GetComponent<CarAI>().CustomDestination = Yer2.transform;
        }
        else if (other.gameObject.CompareTag("Road2"))
        {
            gameObject.GetComponent<CarAI>().CustomDestination = Yer3.transform;
        }
        else if (other.gameObject.CompareTag("Road3"))
        {
            gameObject.GetComponent<CarAI>().CustomDestination = Yer4.transform;
        }
    }
}
