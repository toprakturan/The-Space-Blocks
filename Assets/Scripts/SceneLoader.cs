using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{

    int getPlayingLevelIndex;
    SceneTracker sceneLoad;
    
    
     void Start()
    {
        sceneLoad = FindObjectOfType<SceneTracker>();
    }

    public void LoadNextScene() 
   {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
        
   }

    public void LoadStartScene() 
   {
        
        SceneManager.LoadScene(0);
        FindObjectOfType<GameStatus>().resetGame();
        
   }
      public void QuitGame() 
   {
      
        Application.Quit();
        
   }

    public void loadLastScene()
    {
        SceneManager.LoadScene(sceneLoad.lastloadedsceneIndex);
    }

}
