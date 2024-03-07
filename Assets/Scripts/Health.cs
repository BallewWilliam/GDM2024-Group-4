using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
	public Image healthBar;
	public float healthAmount;

	private void Update()
	{
		if (healthAmount <= 0)
		{
			Application.LoadLevel(Application.loadedLevel);
		}
	}

	public void TakeDamage(float damage) // Added the 'float damage' parameter
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 10;
    }
}
