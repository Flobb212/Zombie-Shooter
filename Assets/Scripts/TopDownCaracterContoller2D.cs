using UnityEngine;
using System.Collections;

public class TopDownCaracterContoller2D : MonoBehaviour {

	// Use this for initialization
	public float speed = 8.1f;
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis ("Vertical");

		GetComponent<Rigidbody2D>().velocity = new Vector2 (x, y) * speed;
		GetComponent<Rigidbody2D>().angularVelocity = 0.0f;	
	}

	IEnumerator HandleOnUpdateSpeed()
	{
		speed = 13;
		yield return new WaitForSeconds (10);
		speed = 8;
	}
}