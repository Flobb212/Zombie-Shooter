using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour
{
	private int healthRegain = 10;
	public AudioClip healthSound;
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player"))
		{
			AudioSource.PlayClipAtPoint(healthSound, transform.position);
			other.transform.SendMessage ("TakeDamage", -healthRegain);			
			Destroy (gameObject);
		}
	}
}