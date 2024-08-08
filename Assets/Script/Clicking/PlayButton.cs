using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void OnPlayButtonPressed()
    {
        // Load the next scene (replace "SceneName" with your scene's name)
        SceneManager.LoadScene("Scene 1");
    }
}

