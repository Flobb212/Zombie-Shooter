using UnityEngine;
using System.Collections;

public class PlayGameButton : MonoBehaviour 
{
	public string levelName = "Level Select";

	void OnMouseUp ()
	{
		Application.LoadLevel (levelName);
	}
}