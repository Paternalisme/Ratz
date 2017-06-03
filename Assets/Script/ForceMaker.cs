using UnityEngine;
using System.Collections;

public class ForceMaker : MonoBehaviour
{

    public GameObject target;
    public int x, y, z;
    public AudioSource optionalAudioSource;
    public Animation camAnim;
    public Camera cam0;
    public Camera cam1;

    void OnTriggerEnter(Collider other)
    {
        target.GetComponent<Rigidbody>().AddForce(x, y, z, ForceMode.Impulse);
        optionalAudioSource.Play();

        StartCoroutine(camUpdate());
    }

    IEnumerator camUpdate()
    {
        cam0.enabled = false;
        cam1.enabled = true;
        camAnim.Play();
        yield return new WaitForSeconds(3f);
        cam1.enabled = false;
        cam0.enabled = true;

        yield return null;
    }
}