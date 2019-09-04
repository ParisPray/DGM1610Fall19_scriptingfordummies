using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable2 : MonoBehaviour
{
    string firstName = "Loki";
    int age = 1054;
    float height = 6.2f;
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
