using UnityEngine;
using System.Collections;

public class ForceMaker : MonoBehaviour {

    public GameObject target;
    public int x, y, z;
    public AudioSource optionalAudioSource;

    void OnTriggerEnter(Collider other)
    {
        target.GetComponent<Rigidbody>().AddForce(x, y, z, ForceMode.Impulse);
        optionalAudioSource.Play();
    }
}
