using UnityEngine;
using System.Collections;

public class ColorChange : MonoBehaviour {

    Color characterColor = new Color(1, 1, 1);

    int timesColorAdded = 0;
    // Use this for initialization
    void Start () {
        foreach(Material material in this.GetComponent<MeshRenderer>().materials)
           material.color = characterColor;
	}

    public void paintRed()
    {
        setMaterialColor(Color.red);
    }

    public void paintGreen()
    {
        setMaterialColor(Color.green);
    }

    public void paintBlue()
    {
        setMaterialColor(Color.blue);
    }

    public void ResetCharacterColor()
    {
        setMaterialColor(Color.white);
        timesColorAdded = 0;
    }

    private void setMaterialColor(Color i_AddedColor)
    {
        if (timesColorAdded < 2)
        { 
            if (timesColorAdded == 0)
            {
                characterColor = i_AddedColor;
            }
            else
            {
                characterColor = (characterColor + i_AddedColor) / 2;
            }
            foreach (Material material in this.GetComponent<MeshRenderer>().materials)
                material.color = characterColor;
            timesColorAdded++;
        }
    }
}
