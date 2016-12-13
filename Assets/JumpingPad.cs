using UnityEngine;
using System.Collections;

public class JumpingPad : MonoBehaviour {

    public CharacterMotor motor;

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
   
    void OnTriggerEnter () {
        motor.SetVelocity(new Vector3(-35, 45, -25));
    }
}
