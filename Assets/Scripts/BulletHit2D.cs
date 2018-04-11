using UnityEngine;
using System.Collections;

public class BulletHit2D : MonoBehaviour
{
	public int damage = 1;
	public string damageTag = "Zombie";

	void OnTriggerEnter2D(Collider2D other )
    {
		if(other.CompareTag (damageTag))
        {
			other.SendMessage ("TakeDamage", damage);
		}
		gameObject.SetActive (false);	
	}
}