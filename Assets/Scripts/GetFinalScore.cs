using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetFinalScore : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI finalScoreText;
     //GameStatus getFinalScore;
    void Start()
    {
        GameObject theScore = GameObject.Find("FinalCanvas");
        GameStatus gameStatus = theScore.GetComponent<GameStatus>();

        // int finalScore = gameObject.GetComponent<GameStatus>().currentScore;
        Debug.Log("Final Score is: " + gameStatus.currentScore);
        
    }

   
    void Update()
    {
        
    }
}
