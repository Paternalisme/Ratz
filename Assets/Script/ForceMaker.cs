using UnityEngine;
using System.Collections;

public class ForceMaker : MonoBehaviour {

    public GameObject target;
    public int x, y, z;
    public AudioSource optionalAudioSource;
    public Animation camAnim;
    public GameObject playerCharacter;
    public Camera cam1;

    void OnTriggerEnter(Collider other)
    {
        target.GetComponent<Rigidbody>().AddForce(x, y, z, ForceMode.Impulse);
        optionalAudioSource.Play();
        
        StartCoroutine(camUpdate());
    }

    IEnumerator camUpdate()
    {
        playerCharacter.SetActive(false);
        cam1.enabled = true;
        camAnim.Play();
        yield return new WaitForSeconds(6.1f);
        cam1.enabled = false;
        playerCharacter.SetActive(true);
        yield return null;
    }
}
