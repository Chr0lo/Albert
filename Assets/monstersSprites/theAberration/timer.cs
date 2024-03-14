using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timer : MonoBehaviour
{
    public float timeRemaining = 60f; // timpul inițial în secunde
    public TMP_Text timerText; // referința către obiectul Text pentru afișarea timpului
    public GameObject final;
    public GameObject aberration;
    public GameObject trap;
    public GameObject six;
    public GameObject head1;    
    public GameObject head2;
    public GameObject head3;
    public GameObject canv;
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime; // scade timpul rămas cu timpul scurs de la ultimul cadru
            DisplayTime(timeRemaining);
        }
        else
        {
            timeRemaining = 0;
            // Dacă timpul a expirat, poți adăuga aici orice acțiune suplimentară dorită
        }

        if(timeRemaining <= 0)
        {
            final.SetActive(true);           
            aberration.SetActive(false);
            trap.SetActive(false);
            six.SetActive(false);
            head1.SetActive(false);
            head2.SetActive(false);
            head3.SetActive(false);
            canv.SetActive(false);
            gameObject.SetActive(false);
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds); // afișează timpul formatat corect în obiectul Text
    }
}
