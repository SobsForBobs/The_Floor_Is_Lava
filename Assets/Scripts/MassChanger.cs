using UnityEngine;

public class MassChanger : MonoBehaviour
{ 
    public Rigidbody rb; // Reference to the Rigidbody component
    private void OnTriggerEnter(Collider other)
    {

      
            rb.mass *= 10000000f; // Increase the mass ten millionfold
            Debug.Log("Mass increased ten millionfold for " + other.name);
       
    }
}
