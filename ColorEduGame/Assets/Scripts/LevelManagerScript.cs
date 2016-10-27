using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class LevelManagerScript : MonoBehaviour 
{
	private Level currentLevel;
	// Use this for initialization

	public Level GetCurrentLevel(){return currentLevel;}

    private Color targetColor;
    private Color currentColor;

    private SpawnRooms spawnManager;
    private float timeCount = 0f;
	void Awake() 
	{
		DontDestroyOnLoad(transform.gameObject);
		currentLevel = new Level ();
        currentLevel.GetJsonData();
        currentLevel.SetLevel (0);
	}

	void Start () 
	{
        currentColor = new Color(1, 1, 1, 0);
        targetColor = new Color(1, 1, 1, 1);
        spawnManager = this.GetComponentInChildren<SpawnRooms>();
	}
    void Update()
    {
        GameObject[] rooms = spawnManager.Rooms;
        MaterialsManage mm = rooms[0].GetComponent<MaterialsManage>();
        mm.CurrentMaterial.color = Color.Lerp(currentColor, targetColor, timeCount/1.0f);
        timeCount += Time.deltaTime;
    }
    int colorRandomCount = 0;
	public void changeLevelColor()
    {
        currentColor = targetColor;
        Color[] allColorsForThisLevel = spawnManager.Colors;
        targetColor = allColorsForThisLevel[colorRandomCount%allColorsForThisLevel.Length];
        colorRandomCount++;
        timeCount = 0f;
    }
}

public class Level
{
    private TextAsset asset;
    private JsonFile lvlData;

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
    public void GetJsonData()
    {
        asset = Resources.Load("lvlInfo") as TextAsset;
        Debug.Log(asset);
        lvlData = JsonUtility.FromJson<JsonFile>(asset.text);
    }

    private void SetLevelInfo()
	{
		//Setting number of rooms
		nrRooms = lvlData.levels[levelNumber].nrRooms;

		//Make color of rooms
		colorPrRoom = new Color[nrRooms];
		colorPrRoom [0] = Color.red;
		colorPrRoom [1] = Color.green;
		colorPrRoom [2] = Color.blue;

		//Setting how many colors can be mixed
		nrOfColorInputs = lvlData.levels[levelNumber].nrOfColorInputs;
	}
}

[System.Serializable]
class JsonFile
{
    [System.Serializable]
    public struct JsonLvlInfo
    {
        public int nrRooms;
        public int nrOfColorInputs;
    }
    public JsonLvlInfo[] levels;
}