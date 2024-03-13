using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyAI : MonoBehaviour
{
	public GameObject Manager;
	private Spell_Comparison spell;
	public TMP_Text Combination2;
	public float RadNum = 0f;
	public bool p1_ready;

    private void Start()
    {
        spell = Manager.GetComponent<Spell_Comparison>();
    }

    public void FixedUpdate()
	{
		if (p1_ready)
		{
			RNG();
			Spells();
			AIDisplay();
			p1_ready = false;
		}
	}

	public void readyButton()
	{
		p1_ready = true;
	}

	public void RNG()
	{
		RadNum = Random.Range(1,7);
	}

	public void Spells()
	{
		if(RadNum == 1)
		{
			spell.Steel2 = true;
			//Debug.Log("Steel2 Selected!");
		}
		if (RadNum == 2)
		{
			spell.Tornado2 = true;
			//Debug.Log("Tornado2 Selected!");
		}
		if (RadNum == 3)
		{
			spell.Steam2 = true;
			//Debug.Log("Steam2 Selected!");
		}
		if (RadNum == 4)
		{
			spell.Flamethrower2 = true;
			//Debug.Log("Flamethrower2 Selected!");

		}
		if (RadNum == 5)
		{
			spell.Ice2 = true;
			//Debug.Log("Ice2 Selected!");
		}
		if (RadNum == 6)
		{
			spell.Storm2 = true;
			//Debug.Log("Storm2 Selected!");
		}
	}
	public void AIDisplay()
	{
		if (spell.Steel2)
			Combination2.text = "Steel";
		if (spell.Tornado2)
			Combination2.text = "Tornado";
		if (spell.Steam2)
			Combination2.text = "Steam";
		if (spell.Flamethrower2)
			Combination2.text = "Flamethrower";
		if (spell.Ice2)
			Combination2.text = "Ice";
		if (spell.Storm2)
			Combination2.text = "Storm";
	}
}


