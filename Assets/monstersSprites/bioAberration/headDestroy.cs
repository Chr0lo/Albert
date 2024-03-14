using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headDestroy : MonoBehaviour
{
   
    public headPoints hd;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bila"))
        {
            
            hd.onHit();
            Destroy(gameObject);

        }
    }
}
