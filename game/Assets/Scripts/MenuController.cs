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

 
    public void LoadLevel(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);  
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
