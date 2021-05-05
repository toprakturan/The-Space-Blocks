using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicPlaying : MonoBehaviour
{
    public int musicIsCount;

    private void Awake()
    {
        musicIsCount = FindObjectsOfType<musicPlaying>().Length;
        DontDestroyOnLoad(transform.gameObject);
        if(musicIsCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {

        }
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
