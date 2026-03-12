using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float speed = 90f; // degrees per second
    public Vector3 axis = Vector3.up; // Y-axis by default

    void Update()
    {
        transform.Rotate(axis * speed * Time.deltaTime);
    }
}