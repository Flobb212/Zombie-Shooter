using UnityEngine;
using System.Collections;

public class GameUI : MonoBehaviour
{

	private int health;
	private int score;
	private string gameInfo = "";
	private Rect pauseRect = new Rect (10, 100, 300, 50);
	private bool gamePaused = false;
	
	private Rect boxRect = new Rect( 10, 10, 300, 50 );

	void Update()
	{
		if (GameObject.FindGameObjectsWithTag ("Zombie").Length == 0 && GameObject.FindGameObjectsWithTag ("Spawner").Length == 0 )
			Application.LoadLevel ("Win Screen");

		if (Input.GetKeyUp (KeyCode.Escape))
		{
				gamePaused = !gamePaused;

			if (gamePaused) {
				Time.timeScale = 0.00001f;
			} else {
				Time.timeScale = 1.0f;
			}
		}
	}

	public static class LevelManager
	{
		private static string lastLevel;
		
		public static void setLastLevel(string level)
		{
			lastLevel = level;
		}
		
		public static string getLastLevel()
		{
			return lastLevel;
		}
		
		public static void changeToPreviousLvl()
		{
			Application.LoadLevel(lastLevel);
		}
	}

	void Awake()
	{
		// Call the LevelManager and set the last level.
		LevelManager.setLastLevel(Application.loadedLevelName);
	}

	void Start()
	{
		UpdateUI();
	}
	
	void OnEnable()
	{
		PlayerBehaviour.onUpdateHealth += HandleOnUpdateHealth;
		AddScore.onSendScore += OnSendScore;
	}

	void OnDisable()
	{
		PlayerBehaviour.onUpdateHealth -= HandleOnUpdateHealth;
		AddScore.onSendScore -= OnSendScore;
	}

	void HandleOnUpdateHealth( int newHealth )
	{
		health = newHealth;
		UpdateUI();
	}

	void OnSendScore( int theScore )
	{
		score += theScore;
		UpdateUI();
	}
	
	void UpdateUI() 
	{
		gameInfo = "Score: " + score.ToString () + "\nHealth: " + health;
	}
	
	void OnGUI() 
	{
		GUI.Box( boxRect, gameInfo );

		if( gamePaused ) {
			GUI.Box( pauseRect, "Game Paused");
		}
	}
}