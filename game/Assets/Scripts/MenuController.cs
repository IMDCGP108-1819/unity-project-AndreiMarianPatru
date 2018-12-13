using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{

    public Button NewGame;
    public Button info;
    public Button Quit;

 //make the buttons load a specific scene
    public void LoadLevel(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);  
    }

    //make the quit  button exit kill the game
    public void QuitGame()
    {
        Application.Quit();
    }
}
