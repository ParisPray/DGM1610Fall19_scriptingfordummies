using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable1 : MonoBehaviour
{
    string firstName = "Squirrel Girl";
    int age = 20;
    float height = 5.3f;
    bool married = false;




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("First Name: " + firstName);
        Debug.Log("Age: " + age);
        Debug.Log("Height: " + height);
        Debug.Log("Married: " + married);
    }

}
