using UnityEngine;
using System.Collections;

public class setWhiteColor : MonoBehaviour {

	private GameObject robot;

	void Start () 
	{
		robot = GameObject.Find ("Robot");
	}

	void OnMouseDown()
	{
		robot.GetComponentInChildren<ColorChange>().ResetCharacterColor();
		Debug.Log ("White!");
	}

}
