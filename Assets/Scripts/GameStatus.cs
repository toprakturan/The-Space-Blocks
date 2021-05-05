using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameStatus : MonoBehaviour
{

    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 55;
    [SerializeField] public int currentScore = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI pausedText;
    [SerializeField] TextMeshProUGUI finalText;

    public int y;
    public int gameStatusCount;

    public bool isPaused = false;
    public bool isFinish = false;

    


    private void Awake()
    {
        
        pausedText.enabled = false;
        gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if (gameStatusCount > 1)
        {

             gameObject.SetActive(false);
             Destroy(gameObject);
             Debug.Log("Burdayım");
        }
        
        else
        {
            DontDestroyOnLoad(gameObject);

            Debug.Log("Burdayım2");
        }
    }


    private void Start()
    {
        scoreText.text = currentScore.ToString();
        finalText.text = currentScore.ToString();

    }

    void Update()
    {

        y = SceneManager.GetActiveScene().buildIndex;
        if(y == 7)
        {
            finalText.enabled = true;
            scoreText.enabled = false;
            
        }
        else
        {
            finalText.enabled = false;
            
        }

        resetGame();
        
        
       
        
        

        Time.timeScale = gameSpeed;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameSpeed = 0;
            pausedText.enabled = true;
            isPaused = true;
            
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            gameSpeed = 0.68f;
            isPaused = false; 
            pausedText.enabled = false;
        }
    }

    public void addScore()
    {
        currentScore += pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString();
        finalText.text = currentScore.ToString();
    }

    public void resetGame()
    {
        if(y == 0)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
            Debug.Log("Burdayımsuan");
        }
        
    }

}
