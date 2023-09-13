using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Gas : MonoBehaviour, IPointerDownHandler, IPointerExitHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        move.Gas = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        move.Gas = false;
    }
}
