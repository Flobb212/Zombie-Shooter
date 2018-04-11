using UnityEngine;
using System.Collections;

public class AssaultRiflePickup : MonoBehaviour 
{
	public AudioClip assaultRifleSound;

	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D info)
	{
		if(info.tag == "Player")
		{
			AudioSource.PlayClipAtPoint(assaultRifleSound, transform.position);
			Debug.Log("Add Assault Rifle message");
			Destroy(gameObject);
		}
	}
}