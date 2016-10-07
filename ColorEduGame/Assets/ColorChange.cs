using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {
    Color cyan = new Color(0, 1, 1);
    Color magenta = new Color(1,0,1);
    Color yellow = new Color(1, 1, 0);

    Color characterColor = new Color(1, 1, 1);

    float addValue = 0.5f;
    // Use this for initialization
    void Start () {
        foreach(Material material in this.GetComponent<MeshRenderer>().materials)
           material.color = characterColor;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void painMoreCyan()
    {
        characterColor.r -= addValue;
        characterColor.r = characterColor.r < 0 ? 0 : characterColor.r;
        foreach (Material material in this.GetComponent<MeshRenderer>().materials)
            material.color = characterColor;
    }

    public void painMoreMagenta()
    {
        characterColor.g -= addValue;
        characterColor.g = characterColor.g < 0 ? 0 : characterColor.g;
        foreach (Material material in this.GetComponent<MeshRenderer>().materials)
            material.color = characterColor;
    }

    public void painMoreYellow()
    {
        characterColor.b -= addValue;
        characterColor.b = characterColor.b < 0 ? 0 : characterColor.b;
        foreach (Material material in this.GetComponent<MeshRenderer>().materials)
            material.color = characterColor;
    }

    public void ResetCharacterColor()
    {
        characterColor = new Color(1, 1, 1);
        foreach (Material material in this.GetComponent<MeshRenderer>().materials)
            material.color = characterColor;
    }
}
