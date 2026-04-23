using UnityEngine;
using UnityEngine.Rendering;



public class ChangeColorOnTouch : MonoBehaviour
{
    private Renderer rend;



    void Start()
    {
        rend = GetComponent<Renderer>();
    }



    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            rend.material.color = Color.yellow;
        }
    }
}