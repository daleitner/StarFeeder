using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunGravity : MonoBehaviour
{
	public float magnetStrength = 5f;

	private Transform trans;
	private Rigidbody thisRd;

	void Awake()
	{
		this.trans = transform;
		this.thisRd = this.trans.GetComponent<Rigidbody>();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			var direction = this.trans.position - other.transform.position;
			other.attachedRigidbody.AddForce(this.magnetStrength * direction, ForceMode2D.Force);
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			coll.transform.position = new Vector3(-15, 5);
			coll.rigidbody.velocity = Vector3.zero;
		}
	}
}