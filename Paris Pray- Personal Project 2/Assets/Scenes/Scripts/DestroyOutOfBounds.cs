using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float xRange = -40;
    public float yRange = 30;
    public float lowerBound = -1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // if object leaves players view in the game, remove that object.
        if (transform.position.x < xRange)
        {
            Destroy(gameObject);
        }


        if (transform.position.y > yRange)
        {

            Destroy(gameObject);
        }
        else if (transform.position.y < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
