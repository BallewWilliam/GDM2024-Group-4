using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
	public GameObject TornadoPrefab; // Prefab of the object to instantiate
	public GameObject SteelPrefab;                               //public Transform elementPosition; // Position to instantiate the object
	public GameObject SteamPrefab;                               //public Transform movementPosition;
	public GameObject IcePrefab;
	public GameObject StormPrefab;
	public GameObject FlamethrowerPrefab;

	public GameObject Manager;
	private Spell_Comparison spell;
    private MultiplayerManager multiplayer;

	public float elementSpeed = 0f;

	public float destroyDelay; // Delay before destroying the instantiated object

	private bool hasElementBeenInstantiated = false; // Flag to track if an element has been instantiated
    private void Start()
    {
        spell = Manager.GetComponent<Spell_Comparison>();
        multiplayer = Manager.GetComponent<MultiplayerManager>();
    }
    void FixedUpdate()
	{
		// Check if the input button is pressed and an element hasn't been instantiated yet
		if ((spell.Tornado1 && multiplayer.P2Ready) && !hasElementBeenInstantiated)
		{
			// Instantiate the object
			GameObject newElement = Instantiate(TornadoPrefab, transform.position, transform.rotation);
			Rigidbody2D elementTransform = newElement.GetComponent<Rigidbody2D>();
			elementTransform.velocity = transform.right * elementSpeed;

			newElement.name = "Tornado";

			// Set the flag to true
			hasElementBeenInstantiated = true;

			// Start a coroutine to destroy the instantiated object after a delay
			StartCoroutine(DestroyElement(newElement));
		}
        if ((spell.Steel1 && multiplayer.P2Ready) && !hasElementBeenInstantiated)
        {
            // Instantiate the object
            GameObject newElement = Instantiate(SteelPrefab, transform.position, transform.rotation);
            Rigidbody2D elementTransform = newElement.GetComponent<Rigidbody2D>();
            elementTransform.velocity = transform.right * elementSpeed;

            newElement.name = "Steel";

            // Set the flag to true
            hasElementBeenInstantiated = true;

            // Start a coroutine to destroy the instantiated object after a delay
            StartCoroutine(DestroyElement(newElement));
        }
        if ((spell.Steam1 && multiplayer.P2Ready) && !hasElementBeenInstantiated)
        {
            // Instantiate the object
            GameObject newElement = Instantiate(SteamPrefab, transform.position, transform.rotation);
            Rigidbody2D elementTransform = newElement.GetComponent<Rigidbody2D>();
            elementTransform.velocity = transform.right * elementSpeed;

            newElement.name = "Steam";

            // Set the flag to true
            hasElementBeenInstantiated = true;

            // Start a coroutine to destroy the instantiated object after a delay
            StartCoroutine(DestroyElement(newElement));
        }
        if ((spell.Ice1 && multiplayer.P2Ready) && !hasElementBeenInstantiated)
        {
            // Instantiate the object
            GameObject newElement = Instantiate(IcePrefab, transform.position, transform.rotation);
            Rigidbody2D elementTransform = newElement.GetComponent<Rigidbody2D>();
            elementTransform.velocity = transform.right * elementSpeed;

            newElement.name = "Ice";

            // Set the flag to true
            hasElementBeenInstantiated = true;

            // Start a coroutine to destroy the instantiated object after a delay
            StartCoroutine(DestroyElement(newElement));
        }
        if ((spell.Storm1 && multiplayer.P2Ready) && !hasElementBeenInstantiated)
        {
            // Instantiate the object
            GameObject newElement = Instantiate(StormPrefab, transform.position, transform.rotation);
            Rigidbody2D elementTransform = newElement.GetComponent<Rigidbody2D>();
            elementTransform.velocity = transform.right * elementSpeed;

            newElement.name = "Storm";

            // Set the flag to true
            hasElementBeenInstantiated = true;

            // Start a coroutine to destroy the instantiated object after a delay
            StartCoroutine(DestroyElement(newElement));
        }
        if ((spell.Flamethrower1 && multiplayer.P2Ready) && !hasElementBeenInstantiated)
        {
            // Instantiate the object
            GameObject newElement = Instantiate(FlamethrowerPrefab, transform.position, transform.rotation);
            Rigidbody2D elementTransform = newElement.GetComponent<Rigidbody2D>();
            elementTransform.velocity = transform.right * elementSpeed;

            newElement.name = "Flamethrower";

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