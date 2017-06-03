using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckpointScript : MonoBehaviour
{

    public int score = 0;
    public Vector3 checkpoint;
    public Animation shelfAnim;
    public Text scoreScreen;
    public GameObject menuPanel;
    public Animation startAnimation;
    public GameObject playerChara;
    public Camera playerCam;
    public Camera introCam;

    // Use this for initialization
    void Start()
    {
        checkpoint = transform.position;
        checkpoint.x = 72.643f;
        checkpoint.y = -60.806f;
        checkpoint.z = 15.3f;
        Cursor.visible = false;
        startAnimation.Play();
    }

    // Update is called once per frame
    void Update()
    {
        scoreScreen.text = score.ToString();
        if (Input.GetKeyDown("r"))
        {
            Die();
        }
        if (Input.GetKeyDown("escape"))
        {
            if (startAnimation.IsPlaying("CameraIntroClip"))
            {
                startAnimation.Stop();
                introCam.enabled = false;
                print("HEYA");
                playerCam.enabled = true;
                playerChara.SetActive(true);
            }
            Cursor.visible = !Cursor.visible;
            GetComponent<MouseLook_Old>().enabled = !GetComponent<MouseLook_Old>().enabled;
            menuPanel.SetActive(!menuPanel.activeSelf);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "First Checkpoint" || other.name == "Second Checkpoint" || other.name == "Third Checkpoint"
            || other.name == "Fourth Checkpoint" || other.name == "Fifth Checkpoint" || other.name == "Sixth Checkpoint")
        {
            checkpoint = other.transform.position;
            Destroy(other.gameObject);
        }
    }

    public void Die()
    {
        transform.position = checkpoint;
        shelfAnim.Play("ShelfResetAnimation");
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Back()
    {
        Cursor.visible = !Cursor.visible;
        GetComponent<MouseLook_Old>().enabled = !GetComponent<MouseLook_Old>().enabled;
        menuPanel.SetActive(!menuPanel.activeSelf);
    }
}