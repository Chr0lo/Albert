using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightWalk : MonoBehaviour
{
    public float verticalSpeed = 5f; // Viteza deplasarii pe verticala
   
    private Rigidbody2D rb;
    public bool isGrounded = true;
    private SpriteRenderer spriteRenderer;

    public float horizontalJumpSpeed = 6f; // Viteza de săritură pe orizontală
    public float horizontalJumpDuration = 0.2f; // Durata săriturii pe orizontală

    private bool isJumping = false;
    private float jumpTimer = 0f;
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

        horizontalMove = Input.GetAxisRaw("Vertical") * verticalSpeed;
        anim.SetFloat("speed", Mathf.Abs(horizontalMove));

        if (isGrounded == true)
        {
            anim.SetBool("jump", false);
        }
        else
        {
            anim.SetBool("jump", true);
        }

        gameObject.transform.rotation = Quaternion.Euler(0, 0, 90);

        Physics2D.gravity = new Vector2(-9.8f, 0);
        rb.gravityScale = -100f;
        float moveVertical = Input.GetAxis("Vertical"); // Input pentru miscarea verticala

        Vector2 movement = new Vector2(0f, moveVertical * verticalSpeed); // Doar miscare verticala

        rb.velocity = movement;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isJumping = true;
            jumpTimer = 0f;
            isGrounded = false;
            jmp.Play();
        }


        if (isJumping)
        {
            

            // Interpolare liniară pentru a mări poziția pe axa X treptat
            float jumpDistance = horizontalJumpSpeed * Time.deltaTime;
            float newXPosition = transform.position.x + jumpDistance * 3f;
            transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);

            // Oprim temporar gravitația
            rb.gravityScale = 0f;

            // Incrementăm timerul de săritură
            jumpTimer += Time.deltaTime;
            if (jumpTimer >= horizontalJumpDuration)
            {
                isJumping = false;
                rb.gravityScale = 1f; // Reluăm gravitația normală
            }

            
        }

        if (moveVertical > 0) // Mergi spre dreapta
        {
            spriteRenderer.flipX = false; // Fata spre dreapta
        }
        else if (moveVertical < 0) // Mergi spre stânga
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
