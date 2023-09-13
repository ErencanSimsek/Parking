using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HedefAlma : MonoBehaviour
{
    [SerializeField]
    Transform MiniMapCam;
    float size = 3.6f;
    Vector3 Temp;
    private void Start()
    {
        MiniMapCam = GameObject.FindWithTag("minimap").GetComponent<Transform>();
    }
    private void Update()
    {
        Temp = transform.parent.transform.position;
        Temp.y = transform.position.y;
        transform.position = Temp;
    }
    private void LateUpdate()
    {
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, MiniMapCam.position.x - size, size + MiniMapCam.position.x),
            transform.position.y,
            Mathf.Clamp(transform.position.z, MiniMapCam.position.z - size, size + MiniMapCam.position.z));

        transform.rotation = Quaternion.Euler(90f, MiniMapCam.eulerAngles.y, 0f);

    }
}
