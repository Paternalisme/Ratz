using UnityEngine;
using System.Collections;

public class FallingShelfScript : MonoBehaviour {

    public Animation fallingShelf;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter()
    {
        fallingShelf.Play();
    }
}
