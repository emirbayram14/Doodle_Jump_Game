using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDrop : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            if (collision.relativeVelocity.y < 0)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = 5f;
                rb.velocity = velocity;
            }
        }
    }
}
