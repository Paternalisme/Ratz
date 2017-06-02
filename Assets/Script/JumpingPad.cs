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
<<<<<<< HEAD
        GameObject.Find("PlayerAudioSource_Spring").GetComponent<AudioSource>().Play();
=======
>>>>>>> 0e8de5618c07172b852f44fd3787d3a1afe65046
        motor.SetVelocity(new Vector3(-45, 45, -25));
        bds.OnTriggerEnter(other);
    }
}
