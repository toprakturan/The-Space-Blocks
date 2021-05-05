using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTracker : MonoBehaviour
{

    public int lastloadedsceneIndex;


    void Start()
    {
        lastloadedsceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    
    void Update()
    {
        

        
    }
}
