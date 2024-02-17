using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickTracker : MonoBehaviour
{
	public Button button1;
	public Button button2;
	public Health healthScript; // Reference to the Health script

	private bool button1Clicked;
	private bool button2Clicked;

	void Start()
	{
		// Attach the onClick listeners to the buttons
		button1.onClick.AddListener(OnButton1Click);
		button2.onClick.AddListener(OnButton2Click);
	}

	void Update()
	{
		// Check if both buttons are clicked
		if (button1Clicked && button2Clicked)
		{
			// Do something when both buttons are clicked
			Debug.Log("Both buttons are clicked!");

			// Reduce health when both buttons are clicked
			healthScript.TakeDamage(10); // You can adjust the damage value as needed

			// Reset button states for future clicks
			button1Clicked = false;
			button2Clicked = false;
		}
	}

	void OnButton1Click()
	{
		// Set button1Clicked to true when button1 is clicked
		button1Clicked = true;
		Debug.Log("Button 1 is clicked!");
	}

	void OnButton2Click()
	{
		// Set button2Clicked to true when button2 is clicked
		button2Clicked = true;
		Debug.Log("Button 2 is clicked!");
	}
}


