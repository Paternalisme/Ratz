using UnityEngine;
using System.Collections;


public class BreadcrumbScript : MonoBehaviour
{

    CheckpointScript checkpoint;

    // Use this for initialization
    void Start()
    {
        checkpoint = FindObjectOfType<CheckpointScript>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            checkpoint.score += 1;
            Destroy(this.gameObject);
        }
    }

}