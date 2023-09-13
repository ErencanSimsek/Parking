using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NVitesDolu : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] GameObject kolu,N;
    bool Dokundu = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        Dokundu = true;
    }
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                if (Dokundu == true)
                {
                    kolu.transform.position = N.transform.position;
                    move.Vites = "N";
                }
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                Dokundu = false;
            }
        }
    }
}
