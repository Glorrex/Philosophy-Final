using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class StartGame : MonoBehaviour
{
    public Button startButton;
   // public Button MainMenuButton;
    void Start()
    {
        startButton.onClick.AddListener(RestartGame);
        //MainMenuButton.onClick.AddListener(MainMenu);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Main Scene");
        PlayerPrefs.DeleteAll();
    }
    //public void MainMenu()
    //{
      //  SceneManager.LoadScene("Philosophy Final");
        //PlayerPrefs.DeleteAll();
    }

//}
