using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Scenes/LevelSelection");
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Scenes/Menu");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Scenes/Map2");
    }

    public void PlayLevel1()
    {
        SceneManager.LoadScene("Scenes/Map1");
    }
}