using UnityEngine;
using System.Collections;

public class KillScript : MonoBehaviour {

    // Animations to reset
    public Animation shelfAnim;

    private Vector3 checkpoint;
	// Use this for initialization
	void Start () {
        checkpoint = transform.position;
        checkpoint.x = 72.643f;
        checkpoint.y = -60.806f;
        checkpoint.z = 15.3f;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        print("DEAD");
        transform.position = checkpoint;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name != "Falling Platform Trigger" &&
            other.name != "JumpPadTrigger" &&
            other.name != "MouseTrapTrigger" &&
            other.name != "First Checkpoint" &&
            other.name != "Second Checkpoint")
        {
            print("DEAD : " + other);
            transform.position = checkpoint;
            shelfAnim.Play("ShelfResetAnimation");
            
        } else if (other.name == "First Checkpoint" || other.name == "Second Checkpoint")
        {
            checkpoint = other.transform.position;
        }
    }
}
