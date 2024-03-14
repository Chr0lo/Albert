using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointsDestroy : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bila"))
        {
            Destroy(gameObject);
           
        }
    }
}
