using UnityEngine;
using System.Collections;

public class FlameThrowerPickup : MonoBehaviour 
{
	public AudioClip flameThrowerSound;

	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D info)
	{
		if(info.tag == "Player")
		{
			AudioSource.PlayClipAtPoint(flameThrowerSound, transform.position);
			Debug.Log("Add Flame Thrower message");
			Destroy(gameObject);
		}
	}
}