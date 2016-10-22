using UnityEngine;
using System.Collections;

public class setGreenColor : MonoBehaviour {
	
	private GameObject robot;

	void Start () 
	{
		robot = GameObject.Find ("Robot");
	}

	void OnMouseDown()
	{
		robot.GetComponentInChildren<ColorChange>().paintGreen();
		Debug.Log ("green!");
	}
}
