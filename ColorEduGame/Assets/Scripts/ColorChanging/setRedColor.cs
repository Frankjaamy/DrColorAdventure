using UnityEngine;
using System.Collections;

public class setRedColor : MonoBehaviour {

	void Start ()
	{
		foreach (Material material in this.GetComponent<MeshRenderer>().materials)
			material.color = Color.red;
	}

	void OnMouseDown()
	{
		this.transform.root.GetComponentInChildren<ColorChange>().paintRed();
		Debug.Log ("Red!");
	}
}
