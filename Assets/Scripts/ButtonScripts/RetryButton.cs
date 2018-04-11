using UnityEngine;
using System.Collections;

public class RetryButton : MonoBehaviour 
{	
	void OnMouseUp ()
	{

		string lastLevel = GameUI.LevelManager.getLastLevel ();

		Application.LoadLevel (lastLevel);
	}
}