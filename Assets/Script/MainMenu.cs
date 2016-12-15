using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    InputManager inputManager;
    private string menu = "Main";
    string buttonToRebind = null;

    void Start()
    {
        inputManager = GameObject.FindObjectOfType<InputManager>();

        // Create one "Key List Item" per button in inputManager
    }

    void OnGUI()
    {
        if (menu.Equals("Main"))
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 75, Screen.height / 2 - 100, 150, 50), "Play"))
            {
                SceneManager.LoadScene("Kitchen");
                //menu = "Play";
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 75, Screen.height / 2 - 25, 150, 50), "Shortcuts"))
            {
                menu = "Shortcuts";
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 75, Screen.height / 2 + 150, 150, 50), "Quit Game"))
            {
                Application.Quit();
            }
        }

        if (menu.Equals("Play"))
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 75, Screen.height / 2 - 100, 150, 50), "Level_1"))
            {
                //Application.LoadLevel("Play");
                menu = "Play";
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 75, Screen.height / 2 + 150, 150, 50), "Return"))
            {
                menu = "Main";
            }
        }

        if (menu.Equals("Shortcuts"))
        {

            GUI.Box(new Rect(Screen.width / 2 + 25, Screen.height / 2 - 170, 100, 30), inputManager.GetKeyNameForButton("Up"));
            GUI.Box(new Rect(Screen.width / 2 - 125, Screen.height / 2 - 170, 100, 30), "Forward");

            GUI.Box(new Rect(Screen.width / 2 + 25, Screen.height / 2 - 110, 100, 30), inputManager.GetKeyNameForButton("Down"));
            GUI.Box(new Rect(Screen.width / 2 - 125, Screen.height / 2 - 110, 100, 30), "Backward");
            
            GUI.Box(new Rect(Screen.width / 2 + 25, Screen.height / 2 - 50, 100, 30), inputManager.GetKeyNameForButton("Right"));
            GUI.Box(new Rect(Screen.width / 2 - 125, Screen.height / 2 - 50, 100, 30), "Right");

            GUI.Box(new Rect(Screen.width / 2 + 25, Screen.height / 2 + 10, 100, 30), inputManager.GetKeyNameForButton("Left"));
            GUI.Box(new Rect(Screen.width / 2 - 125, Screen.height / 2 + 10, 100, 30), "Left");

            GUI.Box(new Rect(Screen.width / 2 + 25, Screen.height / 2 + 70, 100, 30), inputManager.GetKeyNameForButton("Jump"));
            GUI.Box(new Rect(Screen.width / 2 - 125, Screen.height / 2 + 70, 100, 30), "Jump");

            GUI.Box(new Rect(Screen.width / 2 + 25, Screen.height / 2 + 130, 100, 30), "R");
            GUI.Box(new Rect(Screen.width / 2 - 125, Screen.height / 2 + 130, 100, 30), "Load");

            GUI.Box(new Rect(Screen.width / 2 + 25, Screen.height / 2 + 190, 100, 30), "Escape");
            GUI.Box(new Rect(Screen.width / 2 - 125, Screen.height / 2 + 190, 100, 30), "Menu");


            if (GUI.Button(new Rect(Screen.width / 2 - 75, Screen.height / 2 + 250, 150, 50), "Return"))
            {
                menu = "Main";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (buttonToRebind != null)
        {
            if (Input.anyKeyDown)
            {
                // WHICH key was pressed down?!?

                // Loop through all possible keys and see if it was pressed down
                foreach (KeyCode kc in System.Enum.GetValues(typeof(KeyCode)))
                {
                    // Is this key down?
                    if (Input.GetKeyDown(kc))
                    {
                        // Yes!
                        inputManager.SetButtonForKey(buttonToRebind, kc);
 //                       buttonToLabel[buttonToRebind].text = kc.ToString();
                        buttonToRebind = null;
                        break;
                    }
                }

            }
        }

    }

    void StartRebindFor(string buttonName)
    {
        Debug.Log("StartRebindFor: " + buttonName);

        buttonToRebind = buttonName;
    }
}
