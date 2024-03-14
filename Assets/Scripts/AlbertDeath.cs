using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbertDeath : MonoBehaviour
{

    public GameObject death;

    
    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            death.transform.parent = null;
            death.SetActive(true);
            gameObject.SetActive(false);

        }
    }
}
