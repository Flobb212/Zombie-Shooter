using UnityEngine;
using System.Collections;

public class RocketLauncherPickup : MonoBehaviour 
{
	public AudioClip rocketLauncherSound;
	
	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D info)
	{
		if(info.tag == "Player")
		{
			AudioSource.PlayClipAtPoint(rocketLauncherSound, transform.position);
			Debug.Log("Add Rocket Launcher message");
			Destroy(gameObject);
		}
	}
}