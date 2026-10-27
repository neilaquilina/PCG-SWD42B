using UnityEngine;
using UnityEngine.InputSystem;

//Write four methods: GoUp, GoDown, GoLeft, and GoRight. 
// Each one translates 0.04 in that direction and prints 
// the direction it is moving to to the Console. 
// Call the methods when up, down, left and right arrow keys 
// are pressed

public class W03Q03 : MonoBehaviour
{
    float movement = 0.04f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            GoLeft();
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            GoRight();
        }
        if (Keyboard.current.upArrowKey.isPressed)
        {
            GoUp();
        }

        if (Keyboard.current.downArrowKey.isPressed)
        {
            GoDown();
        }
    }

    void GoUp()
    {
        transform.Translate(0f, movement, 0f);
        Debug.Log("Moving forward");
    }

    void GoDown()
    {
        transform.Translate(0f, -movement, 0f);
        Debug.Log("Moving in reverse");
    }

    void GoLeft()
    {
        transform.Translate(-movement, 0f, 0f);
        Debug.Log("Moving left");
    }

    void GoRight()
    {
        transform.Translate(movement, 0f, 0f);
        Debug.Log("Moving right");
    }
}
