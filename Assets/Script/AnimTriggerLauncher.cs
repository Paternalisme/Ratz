using UnityEngine;
using System.Collections;

public class AnimTriggerLauncher : MonoBehaviour {
    public Animation anim;
    public Collider player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other == player)
        {
            anim.Play();
        }

    }
}
