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
        GameObject.Find("Particles").GetComponent<ParticleManager>().changeColor(robot.transform.position);
    }
}
