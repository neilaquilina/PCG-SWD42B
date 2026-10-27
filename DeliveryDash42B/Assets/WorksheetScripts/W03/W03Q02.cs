using UnityEngine;
using UnityEngine.InputSystem;

//Create 2 methods which take care of rotating a GameObject 
// by 2 degrees, one left and one right. The methods are called 
// when either the left arrow key is pressed and 
// when the right arrow key is pressed.

public class W03Q02 : MonoBehaviour
{
    float degrees = 2f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            TurnLeft();
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            TurnRight();
        }
    }

    void TurnLeft()
    {
        transform.Rotate(0f,0f, degrees);
    }

    void TurnRight()
    {
        transform.Rotate(0f,0f, -degrees);
    }

}
