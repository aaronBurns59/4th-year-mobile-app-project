using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // gets the next scene from this current one
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }// PlayGame

    public void QuitGame()
    {
        Debug.Log("The game has been Exited");
        Application.Quit();
    }// QuitGame
}
