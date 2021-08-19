using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpring : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            if (collision.relativeVelocity.y < 0)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = 30f;
                rb.velocity = velocity;
            }
        }
    }
}

