using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardCamera : MonoBehaviour
{
    [SerializeField] GameObject Car;
    public static Vector3 ofset;
    float speed = 200;
    public static bool Forward = true;
    [SerializeField] Camera camera2;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Car = GameObject.FindGameObjectWithTag("Car");
    }
    private void FixedUpdate()
    {
        if (Forward == true)
        {
            gameObject.GetComponent<Camera>().depth = 0;
            camera2.GetComponent<Camera>().depth = -1;
            rb.velocity.Normalize();
            transform.LookAt(Car.transform);

            Quaternion quat = transform.rotation;
            Vector3 vec3 = Car.transform.position + Car.transform.TransformDirection(ofset);

            transform.position = Vector3.Lerp(transform.position, vec3, speed);
            transform.rotation = Quaternion.Lerp(quat, transform.rotation, speed);
        }
    }
}
