using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function4 : MonoBehaviour
{
    // string firstName;
    // string lastName;
    // int age;

    int num1;

    int num2;

    int total;

    // Start is called before the first frame update
    void Start()
    {
        // firstName = "Luigi"

        // lastName = "Nintendo";

        // age = 43;

        // Customer(firstName, lastName, age);
        CalcAdd(7,13);
    }

    int CalcAdd(int n1, int n2)
    {
        Debug.Log("Number 1 =" + n1 + "Number 2 =" + n2);
        total = n1 + n2;
        Debug.Log(total);

        return total;

    }

    // void Customer(string fName, string lName, int a)
    // {
    //    Debug.Log(fName + " " + lName + " " + a)
    // }


    // Update is called once per frame
    void Update()
    {

    }
}
