using UnityEngine;
using System.Collections;

public class WeaponsToPickupsPrevious : MonoBehaviour
{
	public string levelName = "How To Play-Pickups";
	
	void OnMouseUp ()
	{
		Application.LoadLevel (levelName);
	}
}