using UnityEngine;
using System.Collections;

public class SpawnerBehaviour : MonoBehaviour 
{
	public int health = 50;

	public void TakeDamage( int damage )
	{
		health -= damage;

		if (health <= 0) 
		{
			Die ();
			GetComponent<SpawnObject>().Spawn();
			GetComponent<AddScore>().DoSendScore();
		}
	}

	void Die()
	{
		Destroy (gameObject);
	}

}
