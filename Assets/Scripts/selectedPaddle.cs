using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectedPaddle : MonoBehaviour
{

    private int selectedIndex;
   
    void Start()
    {
        
    }


    void Update()
    {
        PlayerPrefs.SetInt("selectedShip", selectedIndex);

    }

    public void selectedShipOne()
    {
        selectedIndex = 1;
        Debug.Log(selectedIndex);
        

    }

    public void selectedShipTwo()
    {
        selectedIndex = 2;
        

    }

    public void selectedShipThree()
    {
        selectedIndex = 3;
        

    }
}
