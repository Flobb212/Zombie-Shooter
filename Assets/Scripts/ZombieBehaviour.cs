using UnityEngine;
using System.Collections;

public class ZombieBehaviour : MonoBehaviour {

	private Transform player;

	private int initialHealth;
	public int health = 10;
	public int damage = 2;

	void Start ()
	{
		if (GameObject.FindWithTag ("Player"))
		{
			player = GameObject.FindWithTag ("Player").transform;
			
			GetComponent<MoveTowardsObject> ().target = player;
			GetComponent<SmoothLookAtTarget2D> ().target = player;
		}
	}

	void Awake() 
	{
		initialHealth = health;
	}

	void OnEnable()
	{
		health = initialHealth;
	}

	public void TakeDamage( int damage )
	{
		health -= damage;

		if (health <= 0)
		{
			GetComponent<SpawnObject>().Spawn();
			GetComponent<SpawnObject>().Drop();
			GetComponent<AddScore>().DoSendScore();
			gameObject.SetActive( false );
		}
	}

	void OnCollisionEnter2D( Collision2D other )
	{
		if (other.gameObject.CompareTag ("Player"))
		{
			other.transform.SendMessage ("TakeDamage", damage);
		}
	}

	void FixedUpdate() {
		GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		GetComponent<Rigidbody2D>().angularVelocity = 0.0f;
	}
}