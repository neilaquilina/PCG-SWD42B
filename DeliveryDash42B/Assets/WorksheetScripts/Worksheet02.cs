using UnityEngine;

public class Worksheet02 : MonoBehaviour
{
    float moveSpeed;

    //Rotate an object once  by 30 degrees and then keep 
    // spinning by 2 degrees every frame
    void Start()
    {
        transform.Rotate(0, 0, 30f);
        //SetSpeed_Q01(0.005f);
        //Show_Q02(25);
        //Show_Q02("Jeffrey");

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 2f);
    }

    


    //Write a void method SetSpeed that takes a float speed 
    // and stores it in a field called moveSpeed.
    void SetSpeed_Q01(float speed)
    {
        moveSpeed = speed;
    }

    //Write two void methods both named Show. 
    // One takes an int, one takes a string. Call both. (overloading)
    void Show_Q02(int int_input)
    {
        int_input *= 2; //int_input = int_input * 2
        Debug.Log("Input multiplied by 2: " + int_input);
    }

    void Show_Q02(string str_input)
    {
        Debug.Log("String: " +str_input);
    }

    
}
