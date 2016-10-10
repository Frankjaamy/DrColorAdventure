using UnityEngine;
using System.Collections;

public class setWhiteColor : MonoBehaviour {

	void Start () 
	{
		foreach (Material material in this.GetComponent<MeshRenderer>().materials)
			material.color = Color.white;
	}

	void OnMouseDown()
	{
		this.transform.root.gameObject.GetComponentInChildren<ColorChange>().ResetCharacterColor();
		Debug.Log ("White!");
	}

}
