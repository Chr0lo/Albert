using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class cannon : MonoBehaviour
{

    public float rotationSpeed = 5f;
    public Transform spawnPoint;
    public GameObject projectilePrefab;
    public GameObject shootingEffect; // Obiectul ce conține efectul de trageri
    public float fireRate = 1f; // Trageri pe secundă
    private float nextFireTime = 0f;
    
    public int currentProjectiles;
    public TMP_Text pro;
    

    void Update()
    {
        

        pro.text = currentProjectiles.ToString();

        RotateTurret();
        if (Input.GetMouseButtonDown(1) && Time.time >= nextFireTime && currentProjectiles > 0) // Butonul dreapta al mouse-ului
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
            StartCoroutine(ActivateShootingEffect());
        }
    }

    void RotateTurret()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f; // Asigură-te că poziția cursorului este pe același plan cu tunul
        Vector2 direction = mousePos - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }

    void Shoot()
    {
        if (currentProjectiles > 0)
        {
            Instantiate(projectilePrefab, spawnPoint.position, transform.rotation);
            currentProjectiles--;
        }
    }

    IEnumerator ActivateShootingEffect()
    {
        // Activează obiectul cu efectul de trageri
        shootingEffect.SetActive(true);
        // Așteaptă 1 secundă
        yield return new WaitForSeconds(1f);
        // Dezactivează obiectul cu efectul de trageri
        shootingEffect.SetActive(false);
        
    }
}
