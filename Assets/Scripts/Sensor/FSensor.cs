using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FSensor : MonoBehaviour
{
    public GameObject[] sensor;
    RaycastHit hit;
    public static bool _6s, _4s, _2s = false;
    [SerializeField] AudioSource _6, _4, _2;
    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        if (move.Vites == "D")
        {
            if (Physics.Raycast(transform.position, fwd, out hit, 2))
            {
                if (_2s == false)
                {
                    _2.Play();
                    Pasif();
                    _2s = true;
                }
                _4.Pause();
                _6.Pause();
                _4s = false;
                _6s = false;
                Debug.DrawRay(transform.position, fwd * hit.distance, Color.green);
            }

            else if (Physics.Raycast(transform.position, fwd, out hit, 4))
            {
                if (_4s == false)
                {
                    _4.Play();
                    Pasif();
                    _4s = true;
                }
                _2.Pause();
                _6.Pause();
                _2s = false;
                _6s = false;
                Debug.DrawRay(transform.position, fwd * hit.distance, Color.yellow);
            }

            else if (Physics.Raycast(transform.position, fwd, out hit, 6))
            {
                if (_6s == false)
                {
                    _6.Play();
                    Pasif();
                    _6s = true;
                }
                _4.Pause();
                _2.Pause();
                _4s = false;
                _2s = false;
                Debug.DrawRay(transform.position, fwd * hit.distance, Color.red);
            }
            else
            {
                _4.Pause();
                _2.Pause();
                _6.Pause();
                Aktif();
                _4s = false;
                _2s = false;
                _6s = false;
            }
        }
        else
        {
            _4.Pause();
            _2.Pause();
            _6.Pause();
            Aktif();
            _4s = false;
            _2s = false;
            _6s = false;
        }
    }
    void Pasif()
    {
        foreach (var item in sensor)
        {
            item.SetActive(false);
        }
    }
    void Aktif()
    {
        foreach (var item in sensor)
        {
            item.SetActive(true);
        }
    }
}
