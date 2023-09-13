using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1Tanitim : MonoBehaviour
{
    [SerializeField] Image IGasSagOk, IGasSolOk, IPOk;
    [SerializeField]GameObject Car;
    private void Awake()
    {
        IGasSagOk = GameObject.FindWithTag("sagok").GetComponent<Image>();
        IGasSolOk = GameObject.FindWithTag("solok").GetComponent<Image>();
        IPOk = GameObject.FindWithTag("pok").GetComponent<Image>();
        Car = GameObject.FindWithTag("Car");
    }
    private void Start()
    {
        
    }
    private void Update()
    {
        SagSolKarar();
        brakePOk();
    }

    void brakePOk()
    {
        if (parkYeri.Park == 4)
        {
            move.GasBrake = true;
            Car.GetComponent<Rigidbody>().isKinematic = true;
            IPOk.enabled = true;
            IGasSagOk.enabled = false;
            IGasSolOk.enabled = false;
        }
    }

    void SagSolKarar()
    {
        if (ContinuePause.SagSol == 0)
        {
            IPOk.enabled = false;
            IGasSagOk.enabled = false;
            IGasSolOk.enabled = true;
        }
        else if (ContinuePause.SagSol == 1)
        {
            IPOk.enabled = false;
            IGasSagOk.enabled = true;
            IGasSolOk.enabled = false;
        }
    }
}
