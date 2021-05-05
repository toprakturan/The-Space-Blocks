using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meteorCollider : MonoBehaviour
{
    private GameObject ship;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        ship = GameObject.FindWithTag("Player");
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("gameOver");
        }

    }
    void Update()
    {
        
    }
}
