using UnityEngine;

public class PauseMenuUI : MonoBehaviour
{
    public GameObject pauseMenu; // Assign this in the inspector

    void Start()
    {
        if (pauseMenu != null)
        {
            Cursor.lockState = CursorLockMode.None; // Unlock the cursor
            Cursor.visible = true; // Make the cursor visible
            pauseMenu.SetActive(false);

        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        AudioListener.pause = false;
    }

    /*public void RestartLevel()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        SceneLoader.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitToMainMenu()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;
        SceneLoader.LoadScene("MainMenu"); // Assuming you have a main menu scene
    }*/
}
