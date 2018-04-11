using UnityEngine;
using System.Collections;

public class SpeedPickup : MonoBehaviour
{
	public delegate void UpdateSpeed( int newSpeed );

	public AudioClip speedSound;

	// Update is called once per frame
	void OnTriggerEnter2D (Collider2D other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			AudioSource.PlayClipAtPoint(speedSound, transform.position);
			Destroy(gameObject);

			other.transform.SendMessage("HandleOnUpdateSpeed");
		}
	}

//	IEnumerator Waiting()
//	{
//		yield return new WaitForSeconds ();
//		print("finish wait");
//		transform.SendMessage("HandleOnUpdateSpeed", speedDown);
//	}
}