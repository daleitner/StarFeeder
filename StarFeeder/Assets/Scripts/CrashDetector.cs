using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			coll.transform.position = new Vector3(-15, 5);
			coll.rigidbody.velocity = Vector3.zero;
			coll.rigidbody.angularVelocity = 0f;
		}
	}
}
