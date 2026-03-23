using UnityEngine;

public class Spinner : MonoBehaviour
{
    public Rigidbody rb; // Reference to the Rigidbody component
    public float speed = 90f; // degrees per second
    public Vector3 axis = Vector3.up; // Y-axis by default

    void Update()
    {
        rb.AddTorque(axis * speed * Time.deltaTime);
        //transform.Rotate(axis * speed * Time.deltaTime);
    }
}