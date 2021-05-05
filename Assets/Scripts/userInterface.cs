using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class userInterface : MonoBehaviour
{
    public string gamerName;
    public GameObject gamerNameField;
    public GameObject nameDisplay;

    public void storeName()
    {
        gamerName = gamerNameField.GetComponent<Text>().text;
        nameDisplay.GetComponent<Text>().text = "Welcome " + gamerName;
    }


}
