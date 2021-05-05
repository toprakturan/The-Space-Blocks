using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlocks : MonoBehaviour
{
    [SerializeField] private float BlockSpeed;
    public Transform pointA, pointB;
    [SerializeField] private float speed;
    public float timer3 = 0.0f;
    public int seconds3;


    void Start()
    {
        
    }

    /*
    private void FixedUpdate()
    {
        speed = 10 * Time.deltaTime;
        transform.position = Vector3.Lerp(pointA.position, pointB.position, speed);
    }
    */
    void Update()
    {
        timer3 += Time.deltaTime;
        seconds3 = (int)(timer3 % 60);
        if(seconds3 % 2 == 1)
        {
            GoRight();
            Debug.Log("timer4");
        }
        else
        {
            GoLeft();
            
        }



    }

    public void GoRight()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    public void GoLeft()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
