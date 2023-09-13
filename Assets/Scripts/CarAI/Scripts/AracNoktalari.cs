using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AracNoktalari : MonoBehaviour
{
    public static List<int> grup = new List<int>();
    private void Start()
    {
        gruplar();
    }
    void gruplar()
    {
        grup.Add(0);
        grup.Add(0);
        grup.Add(0);
        grup.Add(0);
        grup.Add(0);
    }
}
