using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    public float turnspeed;

    private Rigidbody2D rb2d;
    private AudioSource movementSound;

    
    // Use this for initialization
    void Start () {
        movementSound = GetComponent<AudioSource>();
        rb2d = GetComponent<Rigidbody2D>();
       
	}
    

    // Update is called once per frame
    void Update () {
        float moveHorizantal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        transform.Translate (0.0f, moveVertical * speed * Time.deltaTime, 0.0f);
        transform.Rotate(0.0f, 0.0f, moveHorizantal * Time.deltaTime * turnspeed);

        if (Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.S)|| Input.GetKeyDown(KeyCode.D))
        {
            if (!movementSound.isPlaying)
            {
                movementSound.Play();
            }
        }
        else {
            movementSound.Stop();
        }
    }

}
