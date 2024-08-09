using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject player; // Assign your player GameObject in the Inspector
    public Camera mainCamera; // Assign your main camera in the Inspector
    private Vector3 playerPosition;
    private Vector3 cameraPosition;
    private Quaternion cameraRotation;

    void Start()
    {
        // Load the saved player position from PlayerPrefs
        playerPosition = new Vector3(
            PlayerPrefs.GetFloat("PlayerPosX"),
            PlayerPrefs.GetFloat("PlayerPosY"),
            PlayerPrefs.GetFloat("PlayerPosZ")
        );

        // Load the saved camera position and rotation from PlayerPrefs
        cameraPosition = new Vector3(
            PlayerPrefs.GetFloat("CameraPosX"),
            PlayerPrefs.GetFloat("CameraPosY"),
            PlayerPrefs.GetFloat("CameraPosZ")
        );

        cameraRotation = Quaternion.Euler(
             PlayerPrefs.GetFloat("CameraRotX"),
             PlayerPrefs.GetFloat("CameraRotY"),
             PlayerPrefs.GetFloat("CameraRotZ")
         );

        // Set the player's position to the saved position
        player.transform.position = playerPosition;

        // Set the camera's position and rotation to the saved values
        mainCamera.transform.position = cameraPosition;
        mainCamera.transform.rotation = cameraRotation;

        // Re-enable player movement and camera control when resuming
        if (player.GetComponent<FPSController>() != null)
            player.GetComponent<FPSController>().enabled = true;

        if (mainCamera.GetComponent<MouseLook>() != null)
            mainCamera.GetComponent<MouseLook>().enabled = true;
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
