using UnityEngine;
using System.Collections;

public class BreadcrumbScript : MonoBehaviour {

    public CheckpointScript checkpoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnTriggerEnter()
    {
        checkpoint.score += 1;
        Destroy(this.gameObject);
    }
}
