using UnityEngine;

public class Worksheet01 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Welcome_Q01();
        Welcome_Q03("John");
        Welcome_Q04("Gandalf");
        Welcome_Q04();
        ObjectName_Q05();
        LogPrints_Q06();
    }

    // Update is called once per frame
    void Update()
    {
        //Welcome_Q02();
    }

    //Write a void method Welcome that prints 
    // "Welcome to class" and show how to call it.
    void Welcome_Q01()
    {
        Debug.Log("Welcome to class SWD4.2B");
    }

    //Print a message every frame. The message should be stored 
    // in a method and called from either Start() or Update()
    void Welcome_Q02()
    {
        Debug.Log("Print in Update");
    }

    //Change Welcome so it takes a string name and 
    // prints "Welcome to class " + name.
    void Welcome_Q03(string name)
    {
        Debug.Log("Welcome to SWD 4.2B "+name);
    }

    //Give Welcome a default parameter so it works with 
    // or without a name.
    void Welcome_Q04(string name = "Player")
    {
        Debug.Log("Welcome to our group " + name);
    }

    //Create a method that prints the object’s name
    void ObjectName_Q05()
    {
        Debug.Log(gameObject.name);
    }

    //Create a method that prints a normal log, a warning and an error
    void LogPrints_Q06()
    {
        Debug.Log("Normal message");
        Debug.LogWarning("Warning");
        Debug.LogError("ERROR!!");
    }



}
