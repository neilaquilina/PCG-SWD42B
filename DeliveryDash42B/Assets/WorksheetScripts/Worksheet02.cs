using UnityEngine;

public class Worksheet02 : MonoBehaviour
{
    float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetSpeed_Q01(0.005f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Write a void method SetSpeed that takes a float speed 
    // and stores it in a field called moveSpeed.
    void SetSpeed_Q01(float speed)
    {
        moveSpeed = speed;
    }
}
