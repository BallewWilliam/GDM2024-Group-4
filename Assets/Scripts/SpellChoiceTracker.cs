using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellChoiceTracker : MonoBehaviour
{
	public Button button1;
	public Button button2;
	public Health healthScript; // References to the Health script

	private bool button1Clicked;
	private bool button2Clicked;

	void Start()
	{
		button1.onClick.AddListener(OnButton1Click);
		button2.onClick.AddListener(OnButton2Click);
	}

	void Update()
	{
		// Checks if both buttons are clicked
		if (button1Clicked && button2Clicked)
		{
			// Does something when both buttons are clicked
			Debug.Log("Both buttons are clicked!");

			// Reduces health when both buttons are clicked
			healthScript.TakeDamage(10); // You can adjust the damage value as needed

			// Resets button states for future clicks
			button1Clicked = false;
			button2Clicked = false;
		}
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


