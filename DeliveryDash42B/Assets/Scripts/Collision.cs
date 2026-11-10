using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("I collided with "+ collision.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("I triggered with "+ collision.gameObject.name);
    }
}
