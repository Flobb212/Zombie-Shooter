using UnityEngine;
using System.Collections;

public class CityLevelSelectScript : MonoBehaviour
{
	public string levelName = "City Level";
	
	void OnMouseUp ()
	{
		Application.LoadLevel (levelName);
	}
}
