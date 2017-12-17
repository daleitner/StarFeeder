using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    public float turnspeed;
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;

   private float nextFire;
    public float bulletspeed;



    private Rigidbody2D rb2d;
    private AudioSource movementSound;

    
    // Use this for initialization
    void Start () {
        movementSound = GetComponent<AudioSource>();
        rb2d = GetComponent<Rigidbody2D>();
        nextFire = 0.1f;
     

    }


    // Update is called once per frame
    void Update()
    {
        float moveHorizantal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        transform.Translate(0.0f, moveVertical * speed * Time.deltaTime, 0.0f);
        transform.Rotate(0.0f, 0.0f, moveHorizantal * Time.deltaTime * turnspeed);

        /* if (Input.anyKey)
         {
             if (!movementSound.isPlaying)
             {
                 movementSound.Play();
             }
         }
         else
         {
             movementSound.Stop();
         }*/


        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {

            nextFire = Time.time + fireRate;
            GameObject bullet = Instantiate(shot, shotSpawn.position, shotSpawn.rotation);


            
        

            Debug.Log(rb2d.velocity);



        }


    }
}
