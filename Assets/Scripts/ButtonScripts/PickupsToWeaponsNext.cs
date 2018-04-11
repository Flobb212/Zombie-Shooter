using UnityEngine;
using System.Collections;

public class PickupsToWeaponsNext : MonoBehaviour
{
	public string levelName = "How To Play-Weapons";
	
	void OnMouseUp ()
	{
		Application.LoadLevel (levelName);
	}
}