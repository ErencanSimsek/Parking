using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PVitesDolu : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] GameObject kolu,P;
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
                    kolu.transform.position = P.transform.position;
                    move.Vites = "P";
                }
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                Dokundu = false;
            }
        }
    }
}
