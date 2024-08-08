using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveButton : MonoBehaviour
{
    public void OnLeaveButtonPressed()
    {
        // Load the next scene (replace "SceneName" with your scene's name)
        SceneManager.LoadScene("MainMenu");
    }
}
