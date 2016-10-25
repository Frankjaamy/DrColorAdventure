using UnityEngine;
using System.Collections;

public class ParticleManager : MonoBehaviour {
    public GameObject particlesForColorChange;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void changeColor(Vector3 pos)
    {
        particlesForColorChange.transform.position = pos;
        particlesForColorChange.GetComponentInChildren<ParticleSystem>().Play();
    }
}
