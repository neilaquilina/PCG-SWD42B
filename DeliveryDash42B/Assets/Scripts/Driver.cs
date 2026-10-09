using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("1st message to show");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Repeating text");
        PrintMessage();
    }

    void PrintMessage()
    {
        Debug.Log("This message will print when method is called");
    }
}
