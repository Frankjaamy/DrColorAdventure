using UnityEngine;
using System.Collections;

public class LevelManagerScript : MonoBehaviour 
{
	private Level currentLevel;
	// Use this for initialization

	public Level GetCurrentLevel(){return currentLevel;}

	void Awake() 
	{
		DontDestroyOnLoad(transform.gameObject);
		currentLevel = new Level ();
		currentLevel.SetLevel (0);
	}

	void Start () 
	{

	}
	
	//Add functions to navigate levels here
}

public class Level
{
	private int levelNumber = 0;
	private int nrRooms = 0;
	private int nrOfColorInputs = 0;

	private Color[] colorPrRoom;

	public void SetLevel(int lvlNumber)
	{
		levelNumber = lvlNumber;
		SetLevelInfo ();
	}

	public int GetLevelNr(){return levelNumber;}
	public int GetNrOfRooms(){return nrRooms;}
	public int GetNrOfColorInputs(){return nrOfColorInputs;}
	public Color[] GetColorPrRoom(){return colorPrRoom;}

	private void SetLevelInfo()
	{
		if (levelNumber == 0) 
		{
			//Setting number of rooms
			nrRooms = 3;

			//Make color of rooms
			colorPrRoom = new Color[nrRooms];
			colorPrRoom [0] = Color.red;
			colorPrRoom [1] = Color.green;
			colorPrRoom [2] = Color.blue;

			//Setting how many colors can be mixed
			nrOfColorInputs = 1;
		}
	}
}