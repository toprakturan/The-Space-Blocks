using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlokcs2 : MonoBehaviour
{
    [SerializeField] private float BlockSpeed;
    public Transform pointA, pointB;
    [SerializeField] private float speed;
    public float timer4 = 0.0f;
    public int seconds4;


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
        // seconds in float
        timer4 += Time.deltaTime;
        // turn seconds in float to int
        seconds4 = (int)(timer4 % 60);
        if (seconds4 % 2 == 1)
        {
            GoLeft();
            
        }
        else
        {
            GoRight();

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
