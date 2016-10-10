using UnityEngine;
using System.Collections;

public class setGreenColor : MonoBehaviour {

	void Start () 
	{
		foreach (Material material in this.GetComponent<MeshRenderer>().materials)
			material.color = Color.green;
	}

	void OnMouseDown()
	{
		this.transform.root.GetComponentInChildren<ColorChange>().paintGreen();
		Debug.Log ("green!");
	}
}
