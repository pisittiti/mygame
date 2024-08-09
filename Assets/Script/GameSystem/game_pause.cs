using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_pause : MonoBehaviour
{
    public GameObject player; // Assign your player GameObject in the Inspector
    private Vector3 playerPosition;
    public Camera mainCamera; // Assign your main camera in the Inspector
    private Vector3 cameraPosition;
    private Quaternion cameraRotation;


    void Update()
    {
        // Check for pause input (e.g., Escape key)
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        // Store the player's current position
        playerPosition = player.transform.position;

        // Store the camera's current position and rotation
        cameraPosition = mainCamera.transform.position;
        cameraRotation = mainCamera.transform.rotation;

        // Save player's position in PlayerPrefs
        PlayerPrefs.SetFloat("PlayerPosX", playerPosition.x);
        PlayerPrefs.SetFloat("PlayerPosY", playerPosition.y);
        PlayerPrefs.SetFloat("PlayerPosZ", playerPosition.z);

        // Save camera's position and rotation in PlayerPrefs
        PlayerPrefs.SetFloat("CameraPosX", cameraPosition.x);
        PlayerPrefs.SetFloat("CameraPosY", cameraPosition.y);
        PlayerPrefs.SetFloat("CameraPosZ", cameraPosition.z);
        PlayerPrefs.SetFloat("CameraRotX", cameraRotation.eulerAngles.x);
        PlayerPrefs.SetFloat("CameraRotY", cameraRotation.eulerAngles.y);
        PlayerPrefs.SetFloat("CameraRotZ", cameraRotation.eulerAngles.z);
        PlayerPrefs.Save();

        // Disable player movement and camera control
        if (player.GetComponent<FPSController>() != null)
            player.GetComponent<FPSController>().enabled = false;

        if (mainCamera.GetComponent<MouseLook>() != null)
            mainCamera.GetComponent<MouseLook>().enabled = false;


        // Load the PauseGame scene
        SceneManager.LoadScene("PauseMenu");
        UnlockCursor();
    }
    void UnlockCursor()
    {
        Cursor.lockState = CursorLockMode.None; // Unlock the cursor
        Cursor.visible = true; // Make the cursor visible
    }
}

