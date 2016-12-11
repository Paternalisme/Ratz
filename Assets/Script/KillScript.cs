using UnityEngine;
using System.Collections;

public class KillScript : MonoBehaviour {

    private Vector3 checkpoint;
	// Use this for initialization
	void Start () {
        checkpoint = transform.position;
        checkpoint.x = -76.6f;
        checkpoint.y = -38.73f;
        checkpoint.z = 65.8f;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter()
    {
        print("DEAD");
        Vector3 tmp = transform.position;
        tmp.x = -76.6f;
        tmp.y = -38.73f;
        tmp.z = 65.8f;
        transform.position = tmp;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name != "Falling Platform Trigger" && other.name != "JumpPadTrigger")
        {
            print("DEAD : " + other);
            transform.position = checkpoint;
        }
    }
}
