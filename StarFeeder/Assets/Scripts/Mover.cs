using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    public float speed;
    Rigidbody2D rb2d;
    public GameObject player;
    
    

    void Start()
    {



        rb2d = GetComponent<Rigidbody2D>();

        
        
    }
    private void Update()
    {
        rb2d.AddForce(transform.up * speed * 10);
    }
}
