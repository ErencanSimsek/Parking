using UnityEngine;
using UnityEngine.EventSystems;

public class VitesKolu : MonoBehaviour,IPointerDownHandler
{
    RectTransform rect;
    float speed = 25f;
    bool VitesTemas = false, Dokundu = false;
    [SerializeField] Transform P, R, N, D;
    private void Start()
    {
        rect = GetComponent<RectTransform>();
    }

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
                if(Dokundu == true)
                {
                    VitesTemas = true;
                }
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                if (VitesTemas == true)
                {
                    rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, rect.anchoredPosition.y + touch.deltaPosition.y * speed * Time.deltaTime);
                }
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                VitesTemas = false;
                Dokundu = false;
                if (D.position.y >= rect.position.y)
                {
                    move.Vites = "D";
                    rect.position = D.position;
                }
                else if (N.position.y >= rect.position.y)
                {
                    move.Vites = "N";
                    rect.position = N.position;
                }
                else if (R.position.y >= rect.position.y)
                {
                    move.Vites = "R";
                    rect.position = R.position;
                }
                else if (P.position.y >= rect.position.y)
                {
                    move.Vites = "P";
                    rect.position = P.position;
                }
            }
        }
        rect.anchoredPosition = new Vector2(rect.anchoredPosition.x, rect.anchoredPosition.y);
        if (P.localPosition.y < rect.localPosition.y)
        {
            rect.position = P.position;
        }else if(D.localPosition.y > rect.localPosition.y)
        {
            rect.position = D.position;
        }
    }
}
