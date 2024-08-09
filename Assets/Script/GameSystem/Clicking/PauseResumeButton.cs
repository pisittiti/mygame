using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject player; // Assign your player GameObject in the Inspector
    private Vector3 playerPosition;

    void Start()
    {
        // Load the saved player position from PlayerPrefs
        playerPosition = new Vector3(
            PlayerPrefs.GetFloat("PlayerPosX"),
            PlayerPrefs.GetFloat("PlayerPosY"),
            PlayerPrefs.GetFloat("PlayerPosZ")
        );

        // Set the player's position to the saved position
        player.transform.position = playerPosition;

        // Re-enable player movement and camera control when resuming
        if (player.GetComponent<FPSController>() != null)
            player.GetComponent<FPSController>().enabled = true;
    }

    public void ResumeGame()
    {
        Invoke("LoadGameScene", 0.1f);
        // Load the previous game scene
        SceneManager.LoadScene("Scece 1"); // Replace with your actual game scene name
        LockCursor();
    }
    void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked; // Lock the cursor
        Cursor.visible = false; // Hide the cursor
    }
}
