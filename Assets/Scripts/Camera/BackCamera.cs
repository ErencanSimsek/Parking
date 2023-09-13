using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackCamera : MonoBehaviour
{
    GameObject Car;
    [SerializeField] Vector3 ofset;
    float speed = 200;
    [SerializeField] Camera camera1;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Car = GameObject.FindGameObjectWithTag("Car");
    }
    private void FixedUpdate()
    {
        if (ForwardCamera.Forward == false)
        {
            gameObject.GetComponent<Camera>().depth = 0;
            camera1.GetComponent<Camera>().depth = -1;
            rb.velocity.Normalize();
            transform.LookAt(Car.transform);

            Quaternion quat = transform.rotation;
            Vector3 vec3 = Car.transform.position + Car.transform.TransformDirection(ofset);

            transform.position = Vector3.Lerp(transform.position, vec3, speed);
            transform.rotation = Quaternion.Lerp(quat, transform.rotation, speed);
        }
    }
}
