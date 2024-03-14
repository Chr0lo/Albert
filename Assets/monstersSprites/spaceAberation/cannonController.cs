using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonController : MonoBehaviour
{
    
    private Transform spriteTransform;

   
    private Vector3 pozitieInitiala;


    

   
    

    
    

    void Start()
    {
       
        spriteTransform = GetComponent<Transform>();

       
        pozitieInitiala = spriteTransform.position;
    }

    void Update()
    {
        
        Vector3 pozitiaCursorului = Input.mousePosition;

       
        pozitiaCursorului = Camera.main.ScreenToWorldPoint(pozitiaCursorului);

        
        Vector3 directia = (pozitiaCursorului - spriteTransform.position).normalized;

        
        float unghiRotatie = Mathf.Atan2(directia.y, directia.x) * Mathf.Rad2Deg;

        unghiRotatie = Mathf.Clamp(unghiRotatie, -100f, 70f);

        spriteTransform.rotation = Quaternion.Euler(0f, 0f, unghiRotatie);

        spriteTransform.position = pozitieInitiala;


        if (Input.GetMouseButtonDown(1))
        {
            
            
        }
    }





    void LanseazaProiectil()
    {
        
        


    }
}
