using UnityEngine;
using System.Collections;

public class SniperRiflePickup : MonoBehaviour
{
	public AudioClip sniperRifleSound;

	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D info)
	{
		if(info.tag == "Player")
		{
			AudioSource.PlayClipAtPoint(sniperRifleSound, transform.position);
			Debug.Log("Add Sniper Rifle message");
			Destroy(gameObject);
		}
	}
}