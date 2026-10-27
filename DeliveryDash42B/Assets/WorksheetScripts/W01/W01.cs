using UnityEngine;

public class W01_Q01 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Welcome_Q01();
        Welcome_Q03("Gandalf");
        Welcome_Q04();
        Welcome_Q04("Frodo Baggins");
        PrintObjectName_Q05();
        PrintLogTypes_Q06();
    }

    void Update()
    {
        //Welcome_Q02();
    }

    //Write a void method Welcome that prints 
    // "Welcome to class" and show how to call it.
    void Welcome_Q01()
    {
        Debug.Log("Welcome to Class SWD4.2A");
    }

//Print a message every frame. 
// The message should be stored in a method and 
// called from either Start() or Update()

    void Welcome_Q02()
    {
        Debug.Log("Show Message every Frame");
    }

//Change Welcome so it takes a string name and 
// prints "Welcome to class " + name.
    void Welcome_Q03(string name)
    {
        Debug.Log("Welcome to SWD4.2A "+ name);
    }

//Give Welcome a default parameter so it 
// works with or without a name.
    void Welcome_Q04(string name="GOAT Player")
    {
        Debug.Log("Welcome "+name);
    }

//Create a method that prints the object’s name
    void PrintObjectName_Q05()
    {
        Debug.Log(gameObject.name);
    }

//Create a method that prints a normal log, 
// a warning and an error
    void PrintLogTypes_Q06()
    {
        Debug.Log("Normal Message");
        Debug.LogWarning("This is a warning");
        Debug.LogError("This is an Error!!");
    }

}
