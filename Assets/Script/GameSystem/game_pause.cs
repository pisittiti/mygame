using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    private bool isPaused = false;
    private string currentGameScene;

    void Start()
    {
        currentGameScene = SceneManager.GetActiveScene().name;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)) // Press 'P' to toggle pause
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f; // Freeze the game
        SceneManager.LoadScene("PauseMenu", LoadSceneMode.Additive); // Load the pause menu scene additively
        AudioListener.pause = true; // Pause audio
    }

    public void ResumeGame()
    {
        isPaused = false;
        Time.timeScale = 1f; // Resume the game
        SceneManager.UnloadSceneAsync("PauseMenu"); // Unload the pause menu scene
        AudioListener.pause = false; // Resume audio
    }
}
