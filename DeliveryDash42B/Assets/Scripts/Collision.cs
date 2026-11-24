using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pickup"))
        {
            Debug.Log("Package Collected");    
        }

        if (collision.CompareTag("Customer"))
        {
            Debug.Log("Package Delivered");    
        }
        
    }
}
