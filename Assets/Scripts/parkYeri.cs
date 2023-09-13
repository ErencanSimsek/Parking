using UnityEngine;

public class parkYeri : MonoBehaviour
{
    [SerializeField]
    GameObject Park1,Park2,Park3,Park4;
    [SerializeField]
    Material material1,material2;
    public static int Park = 0;

    private void Start()
    {
        Yellow();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Teker1"))
        {
            Park += 1;
        }
        if (other.CompareTag("Teker2"))
        {
            Park += 1;
        }
        if (other.CompareTag("Teker3"))
        {
            Park += 1;
        }
        if (other.CompareTag("Teker4"))
        {
            Park += 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Teker1"))
        {
            Park -= 1;
        }
        if (other.CompareTag("Teker2"))
        {
            Park -= 1;
        }
        if (other.CompareTag("Teker3"))
        {
            Park -= 1;
        }
        if (other.CompareTag("Teker4"))
        {
            Park -= 1;
        }
    }
    private void Yellow()
    {
        Park1.GetComponent<Renderer>().material = material1;
        Park2.GetComponent<Renderer>().material = material1;
        Park3.GetComponent<Renderer>().material = material1;
        Park4.GetComponent<Renderer>().material = material1;
    }
    
    private void FixedUpdate()
    {
        if (Park == 4)
        {
            Park1.GetComponent<Renderer>().material = material2;
            Park2.GetComponent<Renderer>().material = material2;
            Park3.GetComponent<Renderer>().material = material2;
            Park4.GetComponent<Renderer>().material = material2;
        }
        if (Park < 4)
        {
            Yellow();
        }
    }
}
