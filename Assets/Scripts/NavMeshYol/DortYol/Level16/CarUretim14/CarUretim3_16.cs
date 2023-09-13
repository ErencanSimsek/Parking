using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarUretim3_16 : MonoBehaviour
{
    [SerializeField] GameObject[] Car;
    [SerializeField]
    GameObject Yer1, Yer2, Yer3, Yer4, Yer5;
    private void Update()
    {
        if(BoxYer3_16.son == 1)
        {
            Destroy(GameObject.Find(BoxYer3_16.Name));
            Car[BoxYer3_16.numbar].GetComponent<BoxYer3_16>().Yer1 = Yer1.transform;
            Car[BoxYer3_16.numbar].GetComponent<BoxYer3_16>().Yer2 = Yer2.transform;
            Car[BoxYer3_16.numbar].GetComponent<BoxYer3_16>().Yer3 = Yer3.transform;
            Car[BoxYer3_16.numbar].GetComponent<BoxYer3_16>().Yer4 = Yer4.transform;
            Car[BoxYer3_16.numbar].GetComponent<BoxYer3_16>().Yer5 = Yer5.transform;
            Car[BoxYer3_16.numbar].GetComponent<CarAI>().CustomDestination = Yer1.transform;
            Instantiate(Car[BoxYer3_16.numbar], transform.position, transform.rotation, transform);
            BoxYer3_16.son = 0;
        }
    }
}
