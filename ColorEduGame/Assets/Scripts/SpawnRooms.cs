using UnityEngine;
using System.Collections;

public class SpawnRooms : MonoBehaviour {
	//Fill with path to current room prefab
	private string roomPath = "prefabs/room_level_test";

	private LevelManagerScript lvlManager;

	//Room stuff
	private GameObject[] rooms;
	private Color[] colorForRooms;
	private int nrOfRooms;

	private int distanceBetweenRooms = 63;

	// Use this for initialization
	void Start () 
	{
		lvlManager = GameObject.Find ("LevelManager").GetComponent<LevelManagerScript> ();
		CreateRooms ();
	}

	private void CreateRooms()
	{
		nrOfRooms = lvlManager.GetCurrentLevel ().GetNrOfRooms ();
		rooms = new GameObject[nrOfRooms];
		colorForRooms = lvlManager.GetCurrentLevel().GetColorPrRoom();

		int zAxis = 0;

		for (int i = 0; i < nrOfRooms; i++) 
		{
			rooms [i] = (GameObject)Instantiate((GameObject)Resources.Load (roomPath, typeof(GameObject)), new Vector3 (0, 0, zAxis), Quaternion.Euler(0, 90, 0));
			zAxis += distanceBetweenRooms;
			Material newMaterial = new Material (Shader.Find(" Diffuse"));
			foreach (MeshRenderer mRenderer in rooms[i].GetComponentsInChildren<MeshRenderer>())
			{

				mRenderer.sharedMaterial = newMaterial;
				mRenderer.sharedMaterial.color = colorForRooms[i];
			}

		}
	}
}
