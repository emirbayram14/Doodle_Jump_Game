using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    AudioSource jumpsound; 
    Rigidbody2D rb;
    float movementSpeed = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpsound = GetComponent<AudioSource>();
    }


    void Update()
    {
        float movement = Input.GetAxis("Horizontal")*movementSpeed;
        Vector2 tempVelocity = rb.velocity;
        tempVelocity.x = movement;
        rb.velocity = tempVelocity;
    }
}
