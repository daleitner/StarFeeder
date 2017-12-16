using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    private int count;
    public Sprite Sun_1;
    public Sprite Sun_2;
    public Sprite Sun_3;
    public Sprite Sun_4;
    // Use this for initialization
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
       /* if (count >= 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_2;
        }*/

    }

    void OnCollisionEnter2D(Collision2D coll)
    {


        if (coll.gameObject.tag == "Meteroid_1")
        {
         count = count + 1;
            if (count >= 1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_2;
            }

        }

        if (coll.gameObject.tag == "Meteroid_2")
        {
            count = count + 2;
            if (count >= 1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_2;
            }
        }
        if (coll.gameObject.tag == "Meteroid_3")
        {
            count = count + 3;
        if (count >= 1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_2;
            }
            
        }
        if (coll.gameObject.tag == "Meteroid_4")
        {
         count = count + 4;
            if (count >= 1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_2;
            }
        }
        
    }
   
}
