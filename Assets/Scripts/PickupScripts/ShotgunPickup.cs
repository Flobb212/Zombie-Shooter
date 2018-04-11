using UnityEngine;
using System.Collections;

public class ShotgunPickup : MonoBehaviour 
{	
	public AudioClip shotgunSound;

	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D info)
	{
		if(info.tag == "Player")
		{
			AudioSource.PlayClipAtPoint(shotgunSound, transform.position);
			Debug.Log("Add Shotgun message");
			Destroy(gameObject);
		}
	}
}