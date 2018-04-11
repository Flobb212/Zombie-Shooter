using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

	private Animator anim;

	public float adjustmentAngle;
	public float destroyTime = 0.7f;

	void Awake() {
		anim = GetComponent<Animator> ();
		}

	void OnEnable () {
		transform.eulerAngles = new Vector3 (0.0f, 0.0f, transform.eulerAngles.z + adjustmentAngle);
		Invoke ("Die", destroyTime);
		anim.Play ("Explosion");
		}

	void Die() {
		anim.StopPlayback ();
		gameObject.SetActive (false);
	}
}