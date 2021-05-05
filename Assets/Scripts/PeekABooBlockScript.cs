using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeekABooBlockScript : MonoBehaviour
{

    public GameObject block;
    public bool isHide = false;
    public float timer = 0.0f;
    public int seconds;
    MeteorScript myScript;



    void Start()
    {
        

    }

    void Update()
    {
        // seconds in float
        timer += Time.deltaTime;
        // turn seconds in float to int
        seconds = (int)(timer % 60);
        

        if(seconds % 2 == 1)
        {
            
            hideBlock();
            
        }
        else
        {
            showBlock();
        }
    }

    private void hideBlock()
    {
        block.GetComponent<SpriteRenderer>().enabled = false;
        isHide = true;
    }

    private void showBlock()
    {
        block.GetComponent<SpriteRenderer>().enabled = true;
        isHide = false;
    }

    

}
