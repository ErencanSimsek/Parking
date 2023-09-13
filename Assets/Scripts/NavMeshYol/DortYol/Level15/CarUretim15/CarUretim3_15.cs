using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarUretim3_15 : MonoBehaviour
{
    [SerializeField] GameObject[] Car;
    [SerializeField]
    GameObject Yer1, Yer2, Yer3, Yer4;
    private void Update()
    {
        if (BoxYer3_15.son == 1)
        {
            Destroy(GameObject.Find(BoxYer3_15.Name));
            Car[BoxYer3_15.numbar].GetComponent<BoxYer3_15>().Yer1 = Yer1.transform;
            Car[BoxYer3_15.numbar].GetComponent<BoxYer3_15>().Yer2 = Yer2.transform;
            Car[BoxYer3_15.numbar].GetComponent<BoxYer3_15>().Yer3 = Yer3.transform;
            Car[BoxYer3_15.numbar].GetComponent<BoxYer3_15>().Yer4 = Yer4.transform;
            Car[BoxYer3_15.numbar].GetComponent<CarAI>().CustomDestination = Yer1.transform;
            Instantiate(Car[BoxYer3_15.numbar], transform.position, transform.rotation, transform);
            BoxYer3_15.son = 0;
        }
    }
}
