using UnityEngine;
using System.Collections;

public class ForceMaker : MonoBehaviour {

    public GameObject target;
    public int x, y, z;
    public AudioSource optionalAudioSource;
    public Animation camAnim;
<<<<<<< HEAD
    public GameObject playerCharacter;
=======
    public Camera cam0;
>>>>>>> 0e8de5618c07172b852f44fd3787d3a1afe65046
    public Camera cam1;

    void OnTriggerEnter(Collider other)
    {
        target.GetComponent<Rigidbody>().AddForce(x, y, z, ForceMode.Impulse);
        optionalAudioSource.Play();
        
        StartCoroutine(camUpdate());
    }

    IEnumerator camUpdate()
    {
<<<<<<< HEAD
        playerCharacter.SetActive(false);
        cam1.enabled = true;
        camAnim.Play();
        yield return new WaitForSeconds(6.1f);
        cam1.enabled = false;
        playerCharacter.SetActive(true);
=======
        cam0.enabled = false;
        cam1.enabled = true;
        camAnim.Play();
        yield return new WaitForSeconds(3f);
        cam1.enabled = false;
        cam0.enabled = true;
        
>>>>>>> 0e8de5618c07172b852f44fd3787d3a1afe65046
        yield return null;
    }
}
