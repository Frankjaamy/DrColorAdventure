using UnityEngine;
using System.Collections;

public class SpawnRooms : MonoBehaviour {
    //Fill with path to current room prefab
    private string roomPath = "prefabs/room_level_test";

    private LevelManagerScript lvlManager;

    //Room stuff
    private GameObject[] rooms;
     
    private Color[] colorForRooms;
    public Color[] Colors
    {
        get { return colorForRooms; }
    }
    private int nrOfRooms;

    private float distanceBetweenRooms = 14.43f;
    private int spawnCount = 0;
    private float zAxis = 0;

    public GameObject[] Rooms
    {
        get { return rooms; }
    }
	// Use this for initialization
	void Start () 
	{
		lvlManager = GameObject.Find ("LevelManager").GetComponent<LevelManagerScript> ();
        zAxis = 8.2f;
		CreateRooms ();
	}
    public void spawnNewRoom()
    {
        if (spawnCount < nrOfRooms)
        {
            GameObject gTemp = rooms[0];
            gTemp.transform.position = new Vector3(0, 0, zAxis);
            for(var i = 0; i < rooms.Length-1; i++)
            {
                rooms[i] = rooms[i + 1];
            }
            rooms[rooms.Length - 1] = gTemp;
            zAxis += distanceBetweenRooms;
        }
    }
	private void CreateRooms()
	{
		nrOfRooms = lvlManager.GetCurrentLevel ().GetNrOfRooms ();
		rooms = new GameObject[nrOfRooms];
		colorForRooms = lvlManager.GetCurrentLevel().GetColorPrRoom();

		for (int i = 0; i < nrOfRooms; i++) 
		{
			rooms [i] = (GameObject)Instantiate((GameObject)Resources.Load (roomPath, typeof(GameObject)), new Vector3 (0, 0, zAxis), Quaternion.Euler(0, 90, 0));
            zAxis += distanceBetweenRooms;
		}
	}
}
