using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RVitesDolu : MonoBehaviour,IPointerDownHandler
{
    [SerializeField] GameObject kolu, R;
    bool Dokundu = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        Dokundu = true;
    }

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                if(Dokundu == true)
                {
                    kolu.transform.position = R.transform.position;
                    move.Vites = "R";
                }
            }
            else if(touch.phase == TouchPhase.Ended)
            {
                Dokundu = false;
            }
        }
    }
}
