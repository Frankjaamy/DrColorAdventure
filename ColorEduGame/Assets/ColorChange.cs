using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {
	Color blue = new Color (0, 0, 1);
	Color red = new Color (1, 0, 0);
	Color yellow = new Color (1, 1, 0);
	Color green = new Color (0,1,0);

	Color characterColor = new Color (1, 1, 1);
	int appliedColors = 0;

	void Start()
	{
		this.GetComponent<MeshRenderer> ().material.color = characterColor;
	}

	public void Change2Blue()
	{
		if (appliedColors < 2)
		{
			if (characterColor == new Color (1, 1, 1))
			{
				characterColor = blue;
			} else
			{
				Debug.Log (characterColor);
				if (characterColor == yellow)
				{
					characterColor = green;
				} else
				{
					characterColor = ((characterColor + blue) / 2);
				}
			}

			Debug.Log (characterColor);
			this.GetComponent<MeshRenderer> ().material.color = characterColor;
			appliedColors++;
		}
	}

	public void Change2Red()
	{
		if (appliedColors < 2)
		{
			if (characterColor == new Color (1, 1, 1)) 
			{
				characterColor = red;
			}
			else 
			{
				characterColor = ((characterColor + red) / 2);
			}

			this.GetComponent<MeshRenderer> ().material.color = characterColor;

			appliedColors++;
		}
	}

	public void Change2Yellow()
    { 
		if (appliedColors < 2)
		{
			if (characterColor == new Color (1, 1, 1))
			{
				characterColor = yellow;
			} else
			{
				if (characterColor == blue)
				{
					characterColor = green;
				} else
				{
					characterColor = ((characterColor + blue) / 2);
				}
			}
			this.GetComponent<MeshRenderer> ().material.color = characterColor;
			appliedColors++;
		}
	}

	public void ResetCharacterColor()
	{
		characterColor = new Color (1, 1, 1);
		this.GetComponent<MeshRenderer> ().material.color = characterColor;
		appliedColors = 0;
	}
}
