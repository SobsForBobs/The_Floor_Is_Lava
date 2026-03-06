using UnityEngine;

public class BouncyBalls : MonoBehaviour
{
    public float launchForce = 20f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddForce(Vector3.up * launchForce, ForceMode.Impulse);
            }
        }
    }
}