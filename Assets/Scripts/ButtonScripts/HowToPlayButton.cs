using UnityEngine;
using System.Collections;

public class HowToPlayButton : MonoBehaviour
{
	public string levelName = "How To Play-Basics";
	
	void OnMouseUp ()
	{
		Application.LoadLevel (levelName);
	}
}
