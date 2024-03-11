using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Countdown : MonoBehaviour
{
	public float timeLeft = 3f;
	public bool timerOn = false;
	public TMP_Text CountdownTime;
	public Button[] interactableButtons;

	void Start()
	{
		Time.timeScale = 0f; // Set the time scale to 0 to freeze the game
		timerOn = true;

		// Set UI buttons as non-interactable initially
		foreach (var button in interactableButtons)
		{
			button.interactable = false;
		}

		StartCoroutine(StartCountdown());
	}

	IEnumerator StartCountdown()
	{
		while (timerOn)
		{
			if (timeLeft > 0)
			{
				timeLeft -= Time.unscaledDeltaTime; // Use unscaledDeltaTime to ensure accurate countdown when timeScale is 0
				UpdateTimer(timeLeft);
			}
			else
			{
				// Uncomment the line below if you want to perform an action when the time reaches 0
				// Debug.Log("Time is UP!");
				timerOn = false;
			}
			yield return null;
		}

		// Unfreeze the game and enable your game logic here
		Time.timeScale = 1f; // Set the time scale back to 1 to unfreeze the game

		// Set UI buttons as interactable
		foreach (var button in interactableButtons)
		{
			button.interactable = true;
		}

		Debug.Log("Game Unfrozen!");
	}

	void UpdateTimer(float currentTime)
	{
		if (currentTime < 0)
		{
			currentTime = 0; // Ensure it doesn't go below 0
		}

		float seconds = Mathf.FloorToInt(currentTime % 60);

		CountdownTime.text = string.Format("{0}", seconds);
	}
}