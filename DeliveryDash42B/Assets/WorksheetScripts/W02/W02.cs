using UnityEngine;

public class W02 : MonoBehaviour
{
    float moveSpeed;
    int currentFrame = 0;
    
    //Rotate an object once  by 30 degrees and then 
    // keep spinning by 2 degrees every frame
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       // transform.Rotate(0,0, 30f);
        //Show_Q02("Mario");
        //Show_Q02(35);

        
        

    }

    // Update is called once per frame
    void Update()
    {
       // transform.Rotate(0,0, 2f);
       //NudgeAndSpin_Q06();
       SpinAndStop_Q07(300);
    }

//Spin an object for 300 frames and then stop. 
// You have to use another programming concept

    void SpinAndStop_Q07(int framesToRun)
    {
        if (currentFrame < framesToRun)
        {
            transform.Rotate(0,0, 1f);
            currentFrame++;
        }        
    }
// Write a void method SetSpeed that takes a float speed 
// and stores it in a field called moveSpeed.
    void SetSpeed_Q01(float speed)
    {
       moveSpeed = speed; 
    }

//Write two void methods both named Show. 
// One takes an int, one takes a string. Call both. (overloading)

    void Show_Q02(int int_input)
    {
        int_input *= 2;
        Debug.Log(int_input);
    }

    void Show_Q02(string str_input)
    {
        Debug.Log(str_input);
    }

//Write a method NudgeAndSpin that keeps translating 0.05 on X 
// and rotates 3 on Z. Call it from Start() or Update().

    void NudgeAndSpin_Q06()
    {
        transform.Translate(0.05f,0,0);
        transform.Rotate(0,0,3f);
    }



}
