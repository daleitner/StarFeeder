﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrashDetector_MS : MonoBehaviour
{
	static int countMeteors;
	public Sprite Sun_1;
	public Sprite Sun_2;
	public Sprite Sun_3;
	public Sprite Sun_4;
	public Slider slider;
	public Canvas canvas;

	private Animator anim;

	void Start()
	{
		this.anim = this.canvas.GetComponent<Animator>();
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
	    var tag = coll.gameObject.tag;
	    if (tag.Contains("Meteroid"))
	    {
			Destroy(coll.gameObject);
			if (tag == "Meteroid_1")
				countMeteors += 1;
			else if (tag == "Meteroid_2")
				countMeteors += 2;
			else if (tag == "Meteroid_3")
				countMeteors += 3;
			else if (tag == "Meteroid_4")
				countMeteors += 4;

            if (countMeteors >= 20)
            {
                this.anim.SetTrigger("Win");
            }
            else if (countMeteors >= 15)
            { 
                this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_4;
				this.gameObject.transform.localScale = new Vector3(8.0f, 8.0f, 8.0f);
				this.slider.value = 4;
			}
			else if (countMeteors >= 10  )
			{
				this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_3;
				this.gameObject.transform.localScale = new Vector3(6.0f, 6.0f, 6.0f);
				this.slider.value = 3;
			}
			else if (countMeteors >= 5)
			{
				this.gameObject.GetComponent<SpriteRenderer>().sprite = Sun_2;
				this.gameObject.transform.localScale = new Vector3(4.0f, 4.0f, 4.0f);
				this.slider.value = 2;

			}


		}
	}
}