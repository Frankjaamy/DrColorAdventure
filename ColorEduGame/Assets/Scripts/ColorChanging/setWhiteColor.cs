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
        GameObject.Find("Particles").GetComponent<ParticleManager>().changeColor(robot.transform.position);
    }

}
