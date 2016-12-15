using UnityEngine;
using System.Collections;

public class JumpingPad : MonoBehaviour {

    public CharacterMotor motor;
    public BreadcrumbScript bds;

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
   
    void OnTriggerEnter (Collider other) {
        motor.SetVelocity(new Vector3(-45, 45, -25));
        bds.OnTriggerEnter(other);
    }
}
