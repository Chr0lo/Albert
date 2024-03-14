using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellingWalk : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    public float jumpForce;
    public bool isGrounded = true;
    private SpriteRenderer spriteRenderer;
    public Animator anim;
    float horizontalMove = 0f;
    public AudioSource jmp;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        anim.SetFloat("speed", Mathf.Abs(horizontalMove));
        if (isGrounded == true)
        {
            anim.SetBool("jump", false);
        }
        else
        {
            anim.SetBool("jump", true);
        }

        gameObject.transform.rotation = Quaternion.Euler(0, 0, -180);

        Physics2D.gravity = new Vector2(0, -9.8f);

        float moveInput = Input.GetAxis("Horizontal");
        float moveVelocity = moveInput * speed;
        rb.gravityScale = -10f;

        rb.velocity = new Vector2(moveVelocity, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, -jumpForce);
            isGrounded = false;
            jmp.Play();
        }

        if (moveInput > 0) // Mergi spre dreapta
        {
            spriteRenderer.flipX = true; // Fata spre dreapta
        }
        else if (moveInput < 0) // Mergi spre stânga
        {
            spriteRenderer.flipX = false; // Fata spre stânga
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
