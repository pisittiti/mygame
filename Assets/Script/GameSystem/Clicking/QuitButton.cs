using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButton : MonoBehaviour
{
    // This function will be called when the button is clicked
    public void QuitGame()
    {
        // Log a message to the console (helpful for testing in the editor)
        Debug.Log("Game is exiting...");

        // Quit the application
        Application.Quit();

        // Note: Application.Quit() will not work in the Unity Editor.
        // This is just for testing in a build.
    }
}

