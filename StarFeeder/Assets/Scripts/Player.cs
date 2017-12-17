using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
	public Image firstLive;
	public Image secondLive;
	public Image thirdLive;
	public Sprite activeLive;
	public Sprite inactiveLive;
	public Canvas canvas;
	private int lives;
	private int energyLevel;
	private Animator anim;
	private Transform trans;

    // Use this for initialization
    void Start ()
	{
		this.trans = transform;
		this.anim = canvas.GetComponent<Animator> ();
		this.lives = 3;
		this.energyLevel = 1;
		UpdateLives();

    }
	
	// Update is called once per frame
	void Update () {
        
    }

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "Sun" || coll.gameObject.tag.Contains("Meteroid"))
		{
			if (this.lives > 0)
			{
				this.lives--;

				trans.position = new Vector3(-36, 5);
				UpdateLives();
				if(this.lives == 0)
					anim.SetTrigger ("GameOver");
			}
		}
	}

	private void UpdateLives()
	{
		if (this.lives >= 1)
		{
			this.firstLive.sprite = this.activeLive;
		}
		else
		{
			this.firstLive.sprite = this.inactiveLive;
		}
		if (this.lives >= 2)
		{
			this.secondLive.sprite = this.activeLive;
		}
		else
		{
			this.secondLive.sprite = this.inactiveLive;
		}
		if (this.lives >= 3)
		{
			this.thirdLive.sprite = this.activeLive;
		}
		else
		{
			this.thirdLive.sprite = this.inactiveLive;
		}
	}
}
