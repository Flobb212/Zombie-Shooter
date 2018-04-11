using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour
{	
	public delegate void UpdateHealth( int newHealth );
	public static event UpdateHealth onUpdateHealth;

	public int health = 100;
	public Transform walkingTransform;

	private int score;
	private Animator anim;
	private Animator walkingAnim;
	private AudioSource walkingSound;
	private bool isInvincible = false;

	void Start ()
	{
			anim = GetComponent<Animator> ();
			walkingAnim = walkingTransform.GetComponent<Animator> ();
			walkingSound = walkingTransform.GetComponent<AudioSource> ();

			if (onUpdateHealth != null)
				onUpdateHealth (health);
	}

	public void MakePlayerInvincible( float invTime )
	{
		isInvincible = true;
		Invoke( "MakeNormal", invTime );
	}


	void MakeNormal()
	{
		isInvincible = false;
	}

	void Update ()
	{
		if ( Input.GetMouseButton(0) )
		{
			anim.SetBool ("isFiring", true);
		}
		else 
		{
			anim.SetBool ("isFiring", false);
		}

		if (GetComponent<Rigidbody2D>().velocity != Vector2.zero)
		{
			walkingAnim.SetBool ("isWalking", true);

			if (!walkingSound.isPlaying)
			{
				walkingSound.Play ();
				walkingSound.loop = true;
			}
		} 
		else
		{
			walkingAnim.SetBool ("isWalking", false);

			if (walkingSound.isPlaying)
			{
				walkingSound.Stop ();
				walkingSound.loop = false;
			}
		}
	}

	void TakeDamage ( int damage ) 
	{
		if(!isInvincible)
		{
			health -= damage;
		}

		if( onUpdateHealth != null )
			onUpdateHealth( health );

		if( health <= 0 ) 
		{
			Die();
		}
	}

	void Die()
	{
		gameObject.SetActive (false);
		Application.LoadLevel("Game Over");
	}
}