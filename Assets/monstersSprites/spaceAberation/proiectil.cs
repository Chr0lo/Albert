using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proiectil : MonoBehaviour
{
    
    public float lifetime = 2f;
    public float speed = 10f;
    public float jumpForce = 5f; // Puterea de sărit
    private Rigidbody2D rb;
    

    void Start()
    {
        Destroy(gameObject, lifetime);
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("point"))
        {
            Destroy(gameObject);
            Debug.Log("asd");
            
        }
    }

}
