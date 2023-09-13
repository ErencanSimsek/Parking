using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deneme : MonoBehaviour
{
    AudioSource Source;
    bool ses = false;
    private void Start()
    {
        Source = GetComponent<AudioSource>();
    }
    private void FixedUpdate()
    {
        if (ses == false)
        {

            Source.Play();
            ses = true;
        }
    }
}
