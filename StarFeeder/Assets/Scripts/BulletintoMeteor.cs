using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletintoMeteor : MonoBehaviour {

   
    public GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag==("Meteroid_1") || coll.gameObject.tag == ("Meteroid_2") || coll.gameObject.tag == ("Meteroid_3") || coll.gameObject.tag == ("Meteroid_4"))
        {
            Destroy(coll.gameObject);
           // gameObject.transform.parent = player.gameObject.transform;
        
        
        }
    }
}
