using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorScript : MonoBehaviour
{

    public GameObject meteor;
    public float timer2 = 0.0f;
    public int seconds2;
    public bool isCreated = false;
    public Vector2[] positions = new Vector2[7];
    public int randomNumber;


    void Start()
    {
        
        InvokeRepeating("spawn", 1.0f, 30f);



    }

    
    void Update()
    {
        // seconds in float
        timer2 += Time.deltaTime;
        // turn seconds in float to int
        seconds2 = (int)(timer2 % 60);
        if(seconds2 % 2 == 1)
        {
            randomNumberCreator();
            
           
        }
        else
        {

        }
    }

    private void FixedUpdate()
    {
        
    }

    public void spawn()
    {
        GameObject meteorCreator = GameObject.Find("MeteorCreatorObject");
        Instantiate(meteor, meteorCreator.GetComponent<Transform>().position ,Quaternion.identity);
        Debug.Log("spawned");
    }

    public void changePositionOfMeteorCreator()
    {
        
        
        
    }

    public void randomNumberCreator()
    {
        randomNumber = Random.Range(0, positions.Length - 1 );
        GameObject meteorCreator = GameObject.Find("MeteorCreatorObject");
        meteorCreator.GetComponent<Transform>().position = positions[randomNumber];
    }

    
}
