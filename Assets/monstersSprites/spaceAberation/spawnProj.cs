using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnProj : MonoBehaviour
{
    public GameObject spriteToSpawn; // Sprite-ul care va fi spawnat
    public Transform[] spawnPoints; // Lista de puncte de spawn
    public cannon can;
    public int spritesAlive = 0; // Numărul de sprite-uri active în scenă

    void Start()
    {
        SpawnSprites();
    }


    private void Update()
    {
        // Verificăm dacă toate sprite-urile au fost distruse
        if (spritesAlive <= 0 && can.currentProjectiles <=0)
        {
            // Dacă da, se spawn-ează alte sprite-uri
            SpawnSprites();
        }
    }

    void SpawnSprites()
    {
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            // Se spawn-ează sprite-ul la un punct de spawn aleatoriu
            GameObject sprite = Instantiate(spriteToSpawn, spawnPoints[i].position, Quaternion.identity);
            sprite.SetActive(true); // Se activează sprite-ul
            spritesAlive++; // Se incrementează numărul de sprite-uri active

            // Adăugăm o componentă de coliziune 2D și setăm tag-ul "Player" pentru a verifica coliziunea cu jucătorul
            sprite.AddComponent<BoxCollider2D>().isTrigger = true;
            sprite.tag = "Sprite";
        }
    }


    
}
