using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour
{
    public float speed = 5f; //hastighet
    private Rigidbody2D rb;
    private Vector3 moveinput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();//tar komponenten RigidBody2d
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); // A (-1) / D (1)
        float moveY = Input.GetAxisRaw("Vertical");   // W (1) / S (-1)

        moveinput = new Vector3(moveX, moveY).normalized; // Normalize for uniform speed
    }

    private void FixedUpdate()
    {
        rb.velocity = moveinput * speed;
        //rb.MovePosition(transform.position + moveinput * speed * Time.deltaTime);
        //rb.AddForce(moveinput * speed * Time.deltaTime);
    }
}
