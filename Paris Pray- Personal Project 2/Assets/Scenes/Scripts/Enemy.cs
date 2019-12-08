using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;
    public float xRange = 30.0f;
    public AudioClip fireSound;



    // Start is called before the first frame update
    void Start()
    {

    }
  
        // Update is called once per frame
    void Update()
    {



        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
