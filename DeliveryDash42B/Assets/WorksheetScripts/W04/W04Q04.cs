using UnityEngine;
using UnityEngine.InputSystem;

//Create code to store a speed of 5 and a rotation speed of 70. 
// Make MoveHorizontal move right with D and left with A. 
// Make TurnObject rotate with E and Q. 
// Call both methods from Update.

public class W04Q04 : MonoBehaviour
{
    float moveSpeed = 5f;
    float turnSpeed = 70f;

    // Update is called once per frame
    void Update()
    {
        MoveHorizontal();
        TurnObject();
    }

    void MoveHorizontal()
    {
        if(Keyboard.current.dKey.isPressed)
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0f, 0f);
        }

        if(Keyboard.current.aKey.isPressed)
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0f, 0f);
        }
    }

    void TurnObject()
    {
        if(Keyboard.current.eKey.isPressed)
        {
            transform.Rotate(0f, 0f, -turnSpeed*Time.deltaTime);
        }

        if(Keyboard.current.qKey.isPressed)
        {
            transform.Rotate(0f, 0f, turnSpeed*Time.deltaTime);
        }
    }
}
