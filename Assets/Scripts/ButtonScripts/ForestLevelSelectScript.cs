using UnityEngine;
using System.Collections;

public class ForestLevelSelectScript : MonoBehaviour 
{
	public string levelName = "Zombie Shooter Level 1";
	
	void OnMouseUp ()
	{
		Application.LoadLevel (levelName);
	}
}