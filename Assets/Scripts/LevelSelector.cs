using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{

    public GameStatus gameStatus;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void loadLevevl1()
    {
        SceneManager.LoadScene(1);
    }
    public void loadLevevl2()
    {
        SceneManager.LoadScene(2);
    }
    public void loadLevevl3()
    {
        SceneManager.LoadScene(3);
    }
    public void loadLevevl4()
    {
        SceneManager.LoadScene(4);

    }
    public void loadLevevl5()
    {
        SceneManager.LoadScene(5);
    }

    public void closeButton()
    {
        Application.Quit();
    }

    public void tryAgainButton()
    {
        SceneManager.LoadScene(0);
    }

    public void turnMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
