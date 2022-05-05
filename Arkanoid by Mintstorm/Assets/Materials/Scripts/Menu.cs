using UnityEngine;
using UnityEngine.SceneManagement;
//Main task of this script is switching scenes
//Created by Mintstorm April 2022
public class Menu : MonoBehaviour
{

    public void StartGame1()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
    public void StartGame()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1.0f;
    }
    public void Authors()
    {
        SceneManager.LoadScene(1);
    }
    public void HowToPlay()
    {
        SceneManager.LoadScene(2);
    }
    public void Restart()
    {
        SceneManager.LoadScene(3);
        Time.timeScale = 1.0f;
    }
    public void Exit()
    {
        Application.Quit();
    }
        
}

