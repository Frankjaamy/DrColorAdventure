using UnityEngine;
using System.Collections;

public class setBlueColor : MonoBehaviour {

	void Start () 
	{
		foreach (Material material in this.GetComponent<MeshRenderer>().materials)
			material.color = Color.blue;
	}

	void OnMouseDown()
	{
		this.transform.root.GetComponentInChildren<ColorChange>().paintBlue();
		Debug.Log ("Blue!");
	}
}
