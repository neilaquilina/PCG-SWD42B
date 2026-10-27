using UnityEngine;
using UnityEngine.InputSystem;

//Update the code in question 1. Add another variable 'run' 
// with a value of 0.08. Add code so that when the left and right 
// arrow keys are pressed and also the left shift key is pressed, 
// the object starts running at 0.08 speed. It moves back to 0.05 
// when left shift key is released

public class W03Q04 : MonoBehaviour
{
    float movement = 0.05f;
    float run = 0.1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            transform.Translate(-movement, 0f, 0f);
            
            if(Keyboard.current.leftShiftKey.isPressed)
            {
                transform.Translate(-run, 0f,0f);
            }    
            
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
           if(Keyboard.current.leftShiftKey.isPressed)
            {
                transform.Translate(run, 0f,0f);
            }

            if(Keyboard.current.leftShiftKey.isPressed == false)
            {
                transform.Translate(movement, 0f, 0f);
            }
        }
    }
}
