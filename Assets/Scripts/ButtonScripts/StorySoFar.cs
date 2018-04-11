using UnityEngine;
using System.Collections;

public class StorySoFar : MonoBehaviour 
{
	public string levelName = "Main Menu Story Screen";
	
	void OnMouseUp ()
	{
		Application.LoadLevel (levelName);
	}
}