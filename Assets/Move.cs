using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f; //hastighet - Hugo
    private Rigidbody2D rb;
    private Vector3 moveinput;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); // A (-1) / D (1)
        float moveY = Input.GetAxisRaw("Vertical");   // W (1) / S (-1)

        moveinput = new Vector3(moveX, moveY).normalized; // Normalize for uniform speed - Hugo
    }

    private void FixedUpdate()
    {
        rb.velocity = moveinput * speed;
        //rb.MovePosition(transform.position + moveinput * speed * Time.deltaTime);
        //rb.AddForce(moveinput * speed * Time.deltaTime);
    }
}
