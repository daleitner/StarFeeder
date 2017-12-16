using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Meteor_Hit : MonoBehaviour
{
   Rigidbody2D rBody;

    // Use this for initialization
    void Start()
    {
      rBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Laser"))
        {
         
        }
        
        
    }

        }

