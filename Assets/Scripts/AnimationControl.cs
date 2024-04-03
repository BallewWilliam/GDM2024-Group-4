using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
// Instantiate a rigidbody then set the velocity

{
	// Assign a Rigidbody 2D component in the inspector to instantiate

	public GameObject element;
	public GameObject elementPosition;

	void Update()
	{
		// Ctrl was pressed, launch a projectile
		if (Input.GetButtonDown("Element"))
		{
			
			Instantiate(element, elementPosition.transform.position, elementPosition.transform.rotation);
			
			// Give the cloned object an initial velocity along the current
			// object's Z axis
			//clone.velocity = transform.TransformDirection(Vector2.right * 10);
		}
	}
}
