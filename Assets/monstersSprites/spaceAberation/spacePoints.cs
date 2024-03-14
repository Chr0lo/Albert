using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spacePoints : MonoBehaviour
{


    public GameObject hit;
    public gravityBoom poc;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bila"))
        {
            hit.SetActive(true);
            poc.onHit();
            Destroy(gameObject);

        }
    }
}
