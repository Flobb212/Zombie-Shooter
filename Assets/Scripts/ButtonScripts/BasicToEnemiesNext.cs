using UnityEngine;
using System.Collections;

public class BasicToEnemiesNext : MonoBehaviour
{
	public string levelName = "How To Play-Enemies";
	
	void OnMouseUp ()
	{
		Application.LoadLevel (levelName);
	}
}