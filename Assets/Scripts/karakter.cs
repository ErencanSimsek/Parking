using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karakter : MonoBehaviour
{
    Animator animator;
    public static int animasyon = 0;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(animasyon == 2)
        {
            animator.SetInteger("character", 2);
        }
        else if(animasyon == 1)
        {
            animator.SetInteger("character", 1);
        }
        else if(animasyon == 3)
        {
            animator.SetInteger("character", 3);
        }
    }
}
