using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    
    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        //Ana menu kodu girilecek
        SceneManager.LoadScene("Main Menu");
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game4");
    }

    
    


}
