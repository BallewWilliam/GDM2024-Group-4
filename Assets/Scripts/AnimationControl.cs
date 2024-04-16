using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
	public GameObject elementPrefab; // Prefab of the object to instantiate
	//public Transform elementPosition; // Position to instantiate the object
	//public Transform movementPosition;

	public float elementSpeed = 0f;

	public float destroyDelay; // Delay before destroying the instantiated object

	private bool hasElementBeenInstantiated = false; // Flag to track if an element has been instantiated

	void Update()
	{
		// Check if the input button is pressed and an element hasn't been instantiated yet
		if (Input.GetButtonDown("Element") && !hasElementBeenInstantiated)
		{
			// Instantiate the object
			GameObject newElement = Instantiate(elementPrefab, transform.position, transform.rotation);
			Rigidbody2D elementTransform = newElement.GetComponent<Rigidbody2D>();
			elementTransform.velocity = transform.right * elementSpeed;

			newElement.name = "Tornado";

			// Set the flag to true
			hasElementBeenInstantiated = true;

			// Start a coroutine to destroy the instantiated object after a delay
			StartCoroutine(DestroyElement(newElement));
		}
	}

	IEnumerator DestroyElement(GameObject element)
	{
		// Wait for the specified delay
		yield return new WaitForSeconds(destroyDelay);

		// Destroy the instantiated object
		Destroy(element);

		// Reset the flag
		hasElementBeenInstantiated = false;
	}
}