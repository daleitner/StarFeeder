using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector_MS : MonoBehaviour
{
    static int countMeteors;
    public Sprite Sun_1;
    public Sprite Sun_2;
    public Sprite Sun_3;
    public Sprite Sun_4;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Meteroid_1"))
        {
            Destroy(coll.gameObject);
            countMeteors += 1;
            if (countMeteors >= 1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_2;
                this.gameObject.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
            }
            else if (countMeteors == 10)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_3;
                this.gameObject.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
            }
            else if (countMeteors == 15)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_4;
                this.gameObject.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
            }


        }
        if (coll.gameObject.CompareTag("Meteroid_2"))
        {
            Destroy(coll.gameObject);
            countMeteors += 2;
            if (countMeteors >= 1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_2;
                this.gameObject.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
            }
            else if(countMeteors == 10)
                {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_3;
                this.gameObject.transform.localScale = new Vector3(3.0f, 3.0f, 3.0f);
            }
            else if(countMeteors == 15)
                {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_4;
                this.gameObject.transform.localScale = new Vector3(4.0f, 4.0f, 4.0f);
            }
            
        }
        if (coll.gameObject.CompareTag("Meteroid_3"))
        {
            Destroy(coll.gameObject);
            countMeteors += 3;
            if (countMeteors >= 1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_2;
                this.gameObject.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
            }
            else if (countMeteors == 10)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_3;
                this.gameObject.transform.localScale = new Vector3(3.0f, 3.0f, 3.0f);
            }
            else if (countMeteors == 15)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_4;
                this.gameObject.transform.localScale = new Vector3(4.0f, 4.0f, 4.0f);
            }
        }
        if (coll.gameObject.CompareTag("Meteroid_4"))
        {
            Destroy(coll.gameObject);
            countMeteors += 4;
            if (countMeteors >= 1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_2;
                this.gameObject.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
            }
            else if (countMeteors == 10)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_3;
                this.gameObject.transform.localScale = new Vector3(3.0f, 3.0f, 3.0f);
            }
            else if (countMeteors == 15)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_4;
                this.gameObject.transform.localScale = new Vector3(4.0f, 4.0f, 4.0f);
            }
        }
    }
}