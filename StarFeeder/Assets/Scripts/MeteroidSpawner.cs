using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class MeteroidSpawner : MonoBehaviour
{
	public GameObject meteroid_1;
	public GameObject meteroid_2;
	public GameObject meteroid_3;
	public GameObject meteroid_4;

	public GameObject meteroidContainer;

	public int minX;
	public int minY;
	public int maxX;
	public int maxY;

	public int startCount;
	public int maxCount;

	private Transform playerTransform;
	private List<GameObject> meteroids;

	private Random rnd;
	// Use this for initialization
	void Start ()
	{
		this.playerTransform = transform;
		this.meteroids = new List<GameObject> {this.meteroid_1, this.meteroid_2, this.meteroid_3, this.meteroid_4};
		this.rnd = new Random();
		
		for (int i = 0; i < this.startCount; i++)
		{
			GenerateMeteroid();
		}
	}

	private void GenerateMeteroid()
	{
		int randomX;
		int randomY;
		do
		{
			randomX = this.rnd.Next(this.minX, this.maxX);
			randomY = this.rnd.Next(this.minY, this.maxY);
		} while (!IsPositionValid(randomX, randomY));
		Vector3 position = new Vector3(randomX, randomY);
		var meteroidType = this.rnd.Next(4);
		GameObject meteroidToCreate = this.meteroids[meteroidType];
		var newMeteroid = Instantiate(meteroidToCreate, position, Quaternion.identity);
		newMeteroid.transform.parent = this.meteroidContainer.transform;
	}

	// Update is called once per frame
	void Update () {
		
	}

	private bool IsPositionValid(int x, int y)
	{
		if (this.playerTransform.position.x - 5 <= x && this.playerTransform.position.x + 5 >= x
		    && this.playerTransform.position.y - 5 <= y && this.playerTransform.position.y + 5 >= y)
			return false;

		for (int i = 0; i < this.meteroidContainer.transform.childCount; i++)
		{
			var childTransform = this.meteroidContainer.transform.GetChild(i).transform;
			if (childTransform.position.x - 5 <= x && childTransform.position.x + 5 >= x
			    && childTransform.position.y - 5 <= y && childTransform.position.y + 5 >= y)
				return false;
		}
		return true;
	}
}
