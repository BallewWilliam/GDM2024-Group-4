using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
	public float RadNum = 0f;
	public bool Steel2;
	public bool Tornado2;
	public bool Steam2;
	public bool Flamethrower2;
	public bool Ice2;
	public bool Storm2;

	public void FixedUpdate()
	{
		RNG();
		Spells();
	}

	public void RNG()
	{
		RadNum = Random.Range(1,7);
	}

	public void Spells()
	{
		if(RadNum == 1)
		{
			Steel2 = true;
			//Debug.Log("Steel2 Selected!");
		}
		if (RadNum == 2)
		{
			Tornado2 = true;
			//Debug.Log("Tornado2 Selected!");
		}
		if (RadNum == 3)
		{
			Steam2 = true;
			//Debug.Log("Steam2 Selected!");
		}
		if (RadNum == 4)
		{
			Flamethrower2 = true;
			//Debug.Log("Flamethrower2 Selected!");

		}
		if (RadNum == 5)
		{
			Ice2 = true;
			//Debug.Log("Ice2 Selected!");
		}
		if (RadNum == 6)
		{
			Storm2 = true;
			//Debug.Log("Storm2 Selected!");
		}
	}
}


