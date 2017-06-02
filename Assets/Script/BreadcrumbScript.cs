using UnityEngine;
using System.Collections;


public class BreadcrumbScript : MonoBehaviour {

    CheckpointScript checkpoint;

	// Use this for initialization
	void Start () {
        checkpoint = FindObjectOfType<CheckpointScript>();

	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            checkpoint.score += 1;
<<<<<<< HEAD
            GameObject.Find("PlayerAudioSource_Crunch").GetComponent<AudioSource>().Play();
=======
>>>>>>> 0e8de5618c07172b852f44fd3787d3a1afe65046
            Destroy(this.gameObject);
        }
    }

}
