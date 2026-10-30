using UnityEngine;
using UnityEngine.InputSystem;

//Create code to store a speed of 5 and a rotation speed of 100. 
// Make HandleMovement move with WASD. Make HandleRotation rotate with Q and E. 
// Call both from Update. If space is held during movement, 
// print "Moving "in the direction (ex. “Moving Up”) . 
// If space is held during rotation, print "Turning " clockwise or anticlockwise.
//  If left shift is held at any time, print "Shift held".


public class W04Q05 : MonoBehaviour
{
    float moveSpeed = 5f;
    float rotationSpeed = 100f;
    

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        HandleRotation();
        if (Keyboard.current.leftShiftKey.isPressed)
        {
            Debug.Log("Shift pressed");
        }
    }

    void HandleMovement()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            transform.Translate(0f, moveSpeed * Time.deltaTime, 0f);
            if(Keyboard.current.spaceKey.isPressed)
            {
                Debug.Log("Moving forward");
            }
        }

        if (Keyboard.current.sKey.isPressed)
        {
            transform.Translate(0f, -moveSpeed * Time.deltaTime, 0f);
            if(Keyboard.current.spaceKey.isPressed)
            {
                Debug.Log("Moving backward");
            }
        }

        if (Keyboard.current.dKey.isPressed)
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0f, 0f);
            if(Keyboard.current.spaceKey.isPressed)
            {
                Debug.Log("Moving right");
            }
        }

        if (Keyboard.current.aKey.isPressed)
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0f, 0f);
            if(Keyboard.current.spaceKey.isPressed)
            {
                Debug.Log("Moving left");
            }
        }
    }

    void HandleRotation()
    {
        if (Keyboard.current.eKey.isPressed)
        {
            transform.Rotate(0f,0f, -rotationSpeed*Time.deltaTime);
            if(Keyboard.current.spaceKey.isPressed)
            {
                Debug.Log("Turning clockwise");
            }
        }

        if (Keyboard.current.qKey.isPressed)
        {
            transform.Rotate(0f,0f, rotationSpeed*Time.deltaTime);
            if(Keyboard.current.spaceKey.isPressed)
            {
                Debug.Log("Turning anti-clockwise");
            }
        }
    }
}
