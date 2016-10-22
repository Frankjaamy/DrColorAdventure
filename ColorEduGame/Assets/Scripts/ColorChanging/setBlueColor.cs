using UnityEngine;
using System.Collections;

public class setBlueColor : MonoBehaviour {
	
	private GameObject robot;

	void Start () 
	{
		robot = GameObject.Find ("Robot");
	}

	void OnMouseDown()
	{
		robot.GetComponentInChildren<ColorChange>().paintBlue();
		Debug.Log ("Blue!");
	}
}
