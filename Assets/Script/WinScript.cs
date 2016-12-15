using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinScript : MonoBehaviour {

    public GameObject winScreen;

	// Use this for initialization
	void Start () {
        winScreen.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Cursor.visible = true;
            winScreen.SetActive(true);
            FindObjectOfType<MouseLook_Old>().enabled = false;
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
