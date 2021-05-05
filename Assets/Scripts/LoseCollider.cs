using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{


    // public GameObject[] meteor;
    private GameObject meteor;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        meteor = GameObject.FindWithTag("Meteor");
        if (collision.CompareTag("Meteor"))
        {
            Destroy(meteor);
        }
        else
        {
            SceneManager.LoadScene("gameOver");
        }
        
        
        
        
    }

}

