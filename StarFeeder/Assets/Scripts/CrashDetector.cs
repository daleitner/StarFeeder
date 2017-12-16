﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour {

    static int count;

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			coll.transform.position = new Vector3(-15, 5);
			coll.rigidbody.velocity = Vector3.zero;
			coll.rigidbody.angularVelocity = 0f;
		}
        
        if (coll.gameObject.tag == "Meteroid_1")
        {
            Destroy(coll.gameObject);
            count += 1;

        }

        if (coll.gameObject.tag == "Meteroid_2")
        {
            Destroy(coll.gameObject);
            count += 2;
        }
        if (coll.gameObject.tag == "Meteroid_3")
        {
            Destroy(coll.gameObject);
            count += 3;

        }
        if (coll.gameObject.tag == "Meteroid_4")
        {
            Destroy(coll.gameObject);
            count += 4;
        }
        

    }
}