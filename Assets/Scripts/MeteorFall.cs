using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorFall : MonoBehaviour
{
    [SerializeField] private float speed;

    void Start()
    {
       
    }

    
    void Update()
    {
        

        transform.position += Vector3.down * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(tag == "Ground")
        {
            Destroy(this);
        }
    }
}
