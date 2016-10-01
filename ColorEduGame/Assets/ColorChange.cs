using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {
	Color blue = new Color (0, 0, 1);
	Color red = new Color (1, 0, 0);
	Color yellow = new Color (1, 1, 0);
	Color characterColor = new Color (1, 1, 1);
	void Start()
	{
		
	}

	public void Change2Blue()
	{

		characterColor.r -= 0.05f;
		characterColor.g -= 0.05f;
		this.GetComponent<MeshRenderer> ().material.color = characterColor;
	}

	public void Change2Red()
	{

		characterColor.g -= 0.05f;
		characterColor.b -= 0.05f;
		this.GetComponent<MeshRenderer> ().material.color = characterColor;
	}

	public void Change2Yellow()
	{
		characterColor.b -= 0.05f;

		this.GetComponent<MeshRenderer> ().material.color = characterColor;
	}

	public void ResetCharacterColor()
	{
		characterColor = new Color (1, 1, 1);
		this.GetComponent<MeshRenderer> ().material.color = characterColor;
	}
}
