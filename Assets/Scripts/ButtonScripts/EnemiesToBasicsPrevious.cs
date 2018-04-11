using UnityEngine;
using System.Collections;

public class EnemiesToBasicsPrevious : MonoBehaviour 
{
	public string levelName = "How To Play-Basics";
	
	void OnMouseUp ()
	{
		Application.LoadLevel (levelName);
	}
}