using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarUretim1 : MonoBehaviour
{
    [SerializeField]
    GameObject Car, Yer1, Yer2, Yer3;
    private void Awake()
    {
        Car.GetComponent<BoxYer1_14>().Yer1 = Yer1.transform;
        Car.GetComponent<BoxYer1_14>().Yer2 = Yer2.transform;
        Car.GetComponent<BoxYer1_14>().Yer3 = Yer3.transform;
        Car.GetComponent<CarAI>().CustomDestination = Yer1.transform;
        Instantiate(Car, transform.position, transform.rotation, transform);
    }
    private void Start()
    {
        
    }
    private void FixedUpdate()
    {
        if(BoxYer1_14.son == 1)
        {
            Destroy(GameObject.Find("CarUretim1"));
            Destroy(GameObject.Find("CarUretim1(Clone)"));
            Car.GetComponent<BoxYer1_14>().Yer1 = Yer1.transform;
            Car.GetComponent<BoxYer1_14>().Yer2 = Yer2.transform;
            Car.GetComponent<BoxYer1_14>().Yer3 = Yer3.transform;
            Car.GetComponent<CarAI>().CustomDestination = Yer1.transform;
            Instantiate(Car, transform.position, transform.rotation, transform);
            BoxYer1_14.son = 0;
        }
    }
}
