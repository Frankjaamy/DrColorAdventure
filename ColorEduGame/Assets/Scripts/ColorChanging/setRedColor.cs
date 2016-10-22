using UnityEngine;
using System.Collections;

public class setRedColor : MonoBehaviour {

	private GameObject robot;

	void Start ()
	{
		robot = GameObject.Find ("Robot");
	}

	void OnMouseDown()
	{
		robot.GetComponentInChildren<ColorChange>().paintRed();
	}
}
