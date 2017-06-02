using UnityEngine;
using System.Collections;

public class KillScript : MonoBehaviour {

    // Animations to reset
    CheckpointScript checkpoint;


	// Use this for initialization
	void Start () {
        checkpoint = FindObjectOfType<CheckpointScript>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            print("DEAD : " + other);
            checkpoint.Die();
        }
    }
}
