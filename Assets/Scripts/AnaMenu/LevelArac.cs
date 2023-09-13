using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelArac : MonoBehaviour
{
    [SerializeField] GameObject[] Arabalar;
    [SerializeField] Transform Spawn;
    private void Awake()
    {
        Instantiate(Arabalar[Araclar.aktif], Spawn.position, Spawn.rotation);
    }
}
