using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    private float leftLimit = -20;
    private float bottomLimit = -1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > leftLimit)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y >  bottomLimit)
        {
            Destroy(gameObject);
        }
    }
 
}
