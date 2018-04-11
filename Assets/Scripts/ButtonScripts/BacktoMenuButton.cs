using UnityEngine;
using System.Collections;

public class BacktoMenuButton : MonoBehaviour
{
	public string levelName = "Menu";
	
	void OnMouseUp ()
	{
		Application.LoadLevel (levelName);
	}
}