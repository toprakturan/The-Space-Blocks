using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class level : MonoBehaviour
{
    [SerializeField] int breakableBlocks;
    GameObject[] unbreakableBlocks;
    SceneLoader sceneloader;
    GameObject[] breakableBlocksNumber;
    

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
        
    }

    public void Update()
    {
        unbreakableBlocks = GameObject.FindGameObjectsWithTag("Unbreakable");
        breakableBlocksNumber = GameObject.FindGameObjectsWithTag("Breakable");
        Debug.Log(unbreakableBlocks.Length);
        Debug.Log(breakableBlocksNumber.Length);
        blockDestroyed();
    }

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void blockDestroyed()
    {
        breakableBlocks--;
        if(breakableBlocksNumber.Length <= 0)
        {
            sceneloader.LoadNextScene();
        }
    }
}
