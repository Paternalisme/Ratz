using UnityEngine;
using System.Collections;

public class JumpingPad : MonoBehaviour {

    public Rigidbody rigidbody;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
   
    void OnTriggerEnter () {
        print("hello");
        rigidbody.isKinematic = false;
        rigidbody.AddForce(0, 10, 0, ForceMode.Impulse);
        //rigidbody.isKinematic = true;
    }
}
