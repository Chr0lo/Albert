using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    public float jumpForce;
    public bool isGrounded = true;
    private SpriteRenderer spriteRenderer;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

        gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);

        Physics2D.gravity = new Vector2(0, -9.8f);
        rb.gravityScale = 10f;

        float moveInput = Input.GetAxis("Horizontal");
        float moveVelocity = moveInput * speed;

        rb.velocity = new Vector2(moveVelocity, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false;
        }

        if (moveInput > 0) // Mergi spre dreapta
        {
            spriteRenderer.flipX = false; // Fata spre dreapta
        }
        else if (moveInput < 0) // Mergi spre stânga
        {
            spriteRenderer.flipX = true; // Fata spre stânga
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
