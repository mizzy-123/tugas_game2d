using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("Level1");
    }

    public void Back()
    {
        SceneManager.LoadSceneAsync("HomeScreen");
    }

    public void  QuitGame()
    {
        Debug.Log("QuitGame function called");
        Application.Quit();
    }



}
