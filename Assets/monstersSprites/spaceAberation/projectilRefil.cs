using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilRefil : MonoBehaviour
{


    public int projNum;
    public cannon can;
    public spawnProj sp;

    public void Start()
    {
        can = FindAnyObjectByType<cannon>();
        sp = FindAnyObjectByType<spawnProj>();
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            can.currentProjectiles = can.currentProjectiles + projNum;
            sp.spritesAlive = sp.spritesAlive - 1;
            Destroy(gameObject);
        }
    }



}
