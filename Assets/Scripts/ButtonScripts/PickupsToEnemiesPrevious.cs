using UnityEngine;
using System.Collections;

public class PickupsToEnemiesPrevious : MonoBehaviour
{
	public string levelName = "How To Play-Enemies";
	
	void OnMouseUp ()
	{
		Application.LoadLevel (levelName);
	}
}