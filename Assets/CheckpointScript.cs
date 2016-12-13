using UnityEngine;
using System.Collections;

public class CheckpointScript : MonoBehaviour {

    public int score = 0;
    public Vector3 checkpoint;
    public Animation shelfAnim;

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

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "First Checkpoint" || other.name == "Second Checkpoint")
        {
            checkpoint = other.transform.position;
        }
    }

    public void Die()
    {
        transform.position = checkpoint;
        shelfAnim.Play("ShelfResetAnimation");
    }
}
