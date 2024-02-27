using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellDamage : MonoBehaviour
{
	public Button button1;
	public Button button2;
	public float damageAmount;

	private bool button1Clicked;
	private bool button2Clicked;
	private Health healthScript; // Reference to the Health script


	void Start()
	{
		button1.onClick.AddListener(OnButton1Click);
		button2.onClick.AddListener(OnButton2Click);

		// Get the Health script component
		healthScript = GetComponent<Health>();
	}

	void Update()
	{
		// Checks if both buttons are clicked
		if (button1Clicked && button2Clicked)
		{
			// Does something when both buttons are clicked
			Debug.Log("Both buttons are clicked!");

			 // Set the damage globally using the SpellDamage script
            healthScript.TakeDamage();
		
			// Resets button states for future clicks
			button1Clicked = false;
			button2Clicked = false;
		}
	}

	public void DealDamage(float Damage)
	{
		damageAmount = Damage;
	}

	void OnButton1Click()
	{
		// Sets button1Clicked to true when button1 is clicked
		button1Clicked = true;
		Debug.Log("Button 1 is clicked!");
	}

	void OnButton2Click()
	{
		// Sets button2Clicked to true when button2 is clicked
		button2Clicked = true;
		Debug.Log("Button 2 is clicked!");
	}
}


