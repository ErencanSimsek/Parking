using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarUretim3 : MonoBehaviour
{
    [SerializeField]
    GameObject Car, Yer1, Yer2, Yer3;
    private void Awake()
    {
        Car.GetComponent<BoxYer3_14>().Yer1 = Yer1.transform;
        Car.GetComponent<BoxYer3_14>().Yer2 = Yer2.transform;
        Car.GetComponent<BoxYer3_14>().Yer3 = Yer3.transform;
        Car.GetComponent<CarAI>().CustomDestination = Yer1.transform;
        Instantiate(Car, transform.position, transform.rotation, transform);
    }
    private void FixedUpdate()
    {
        if(BoxYer3_14.son == 1)
        {
            Destroy(GameObject.Find("CarUretim3"));
            Destroy(GameObject.Find("CarUretim3(Clone)"));
            Car.GetComponent<BoxYer3_14>().Yer1 = Yer1.transform;
            Car.GetComponent<BoxYer3_14>().Yer2 = Yer2.transform;
            Car.GetComponent<BoxYer3_14>().Yer3 = Yer3.transform;
            Car.GetComponent<CarAI>().CustomDestination = Yer1.transform;
            Instantiate(Car, transform.position, transform.rotation, transform);
            BoxYer3_14.son = 0;
        }
    }
}
