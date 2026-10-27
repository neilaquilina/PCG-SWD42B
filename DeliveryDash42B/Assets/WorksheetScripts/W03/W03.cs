using UnityEngine;
using UnityEngine.InputSystem;

public class W03 : MonoBehaviour
{

    float movement = 0.05f;

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
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            transform.Translate(movement, 0f, 0f);
        }
    }

    //Q01: Create code to move an object left and right only using 
    // the left and right arrow keys. The movement should be by 0.05f. 
    // Save this number in a variable

}
