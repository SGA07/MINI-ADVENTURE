using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menucontroller : MonoBehaviour
{
    public void PlaGame()
    {
        SceneManager.LoadScene("levelselector");
    }
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Level3()
    {
        SceneManager.LoadScene("Level3");
    }


    public void Back()
    {
        SceneManager.LoadScene("mainmenu");
    }
     public void Quitgame()
    {
        Application.Quit();
    }



}
