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

	void OnTriggerExit2D(Collider2D other)
	{
		other.attachedRigidbody.velocity = Vector3.zero;
		other.attachedRigidbody.angularVelocity = 0f;
	}
}