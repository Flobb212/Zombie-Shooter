using UnityEngine;
using System.Collections;

public class ShieldPickup : MonoBehaviour 
{
	private float invTime = 10;
	public bool canTakeDamage = true;
	public AudioClip shieldSound;

	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D info)
	{
		if(info.tag == "Player")
		{
			makeInvincible();
			AudioSource.PlayClipAtPoint(shieldSound, transform.position);
			info.SendMessage( "MakePlayerInvincible", invTime );
			Destroy(gameObject);
		}
	}

	void makeInvincible()
	{
		canTakeDamage = false;
		if (invTime <= 0)
		canTakeDamage = true;
	}

	void Update()
	{
		//invTime -= Time.deltaTime;
	}
}