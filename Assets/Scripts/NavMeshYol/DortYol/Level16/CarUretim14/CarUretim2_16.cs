using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarUretim2_16 : MonoBehaviour
{
    [SerializeField] GameObject[] Car;
    [SerializeField]
    GameObject Yer1, Yer2, Yer3, Yer4, Yer5;
    private void Update()
    {
        if(BoxYer2_16.son == 1)
        {
            Destroy(GameObject.Find(BoxYer2_16.Name));
            Car[BoxYer2_16.numbar].GetComponent<BoxYer2_16>().Yer1 = Yer1.transform;
            Car[BoxYer2_16.numbar].GetComponent<BoxYer2_16>().Yer2 = Yer2.transform;
            Car[BoxYer2_16.numbar].GetComponent<BoxYer2_16>().Yer3 = Yer3.transform;
            Car[BoxYer2_16.numbar].GetComponent<BoxYer2_16>().Yer4 = Yer4.transform;
            Car[BoxYer2_16.numbar].GetComponent<BoxYer2_16>().Yer5 = Yer5.transform;
            Car[BoxYer2_16.numbar].GetComponent<CarAI>().CustomDestination = Yer1.transform;
            Instantiate(Car[BoxYer2_16.numbar], transform.position, transform.rotation, transform);
            BoxYer2_16.son = 0;
        }
    }
}
