using UnityEngine;
using System.Collections;

public class GameScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ChangeToRandomColor()
    {
        float r = Random.value;
        float g = Random.value;
        float b = Random.value;
        Color color = new Vector4(r,g,b,1);

        Material mat = GameObject.Find("gameScene/pCube8").GetComponent<MeshRenderer>().material;
        mat.color = color;
    }
}
