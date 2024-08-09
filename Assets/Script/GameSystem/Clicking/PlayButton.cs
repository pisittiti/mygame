using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class YourScript : MonoBehaviour
{
    public void OnPlayButtonPressed()
    {
        StartCoroutine(DelayedAction());
    }

    private IEnumerator DelayedAction()
    {
        // Wait for 8 seconds
        yield return new WaitForSeconds(0.2f);
        
        // Perform the action after the delay
        Debug.Log("Action executed after delay!");
        
        // Load the next scene (replace "Scene 1" with your scene's name)
        SceneManager.LoadScene("Scene 1");
    }
}
