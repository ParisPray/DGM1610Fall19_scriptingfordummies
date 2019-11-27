using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBounce : MonoBehaviour
{
    public bool isOnGround = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            
        }
    }
}