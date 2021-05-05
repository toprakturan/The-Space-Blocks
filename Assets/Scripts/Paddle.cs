
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paddle : MonoBehaviour
{

    
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;

    int getIndex;
    public Sprite ship1;
    public Sprite ship2;
    public Sprite ship3;
    void Start()
    {
        getIndex = PlayerPrefs.GetInt("selectedShip");

        if (getIndex == 1)
        {
            GetComponent<SpriteRenderer>().sprite = ship1;
           
        }
        else if (getIndex == 2)
        {
            GetComponent<SpriteRenderer>().sprite = ship2;
            
        }
        else if (getIndex == 3)
        {
            GetComponent<SpriteRenderer>().sprite = ship3;
        }
    }

    // Update is called once per frame
    void Update()
    {

        

        float mousePosInUnits = Input.mousePosition.x/Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = Mathf.Clamp(mousePosInUnits,minX,maxX);
        transform.position = paddlePos;
        


    }
}
