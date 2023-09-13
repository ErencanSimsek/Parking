using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Brake : MonoBehaviour,IPointerDownHandler, IPointerExitHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        move.Brake = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        move.Brake = false;
    }
}
