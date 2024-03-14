using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Writing : MonoBehaviour
{
    public TMP_Text subtitleText;
    public string fullText;
    private string currentText = "";
    public float minTypingSpeed = 0.05f;
    public float maxTypingSpeed = 0.2f;
    public int sv;

    public GameObject continueButton;

    void Start()
    {
        StartCoroutine(ShowSubtitle());
    }

    IEnumerator ShowSubtitle()
    {
        for (int i = 0; i <= fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            subtitleText.text = currentText;

            // Alege o viteză aleatoare între minTypingSpeed și maxTypingSpeed
            float randomSpeed = Random.Range(minTypingSpeed, maxTypingSpeed);

            yield return new WaitForSeconds(randomSpeed);

            // Verifică dacă textul este complet scris și activează obiectul în consecință
            if (currentText == fullText)
            {
                // Înlocuiește "numeleObiectului" cu numele real al obiectului pe care dorești să-l activezi
                continueButton.SetActive(true);
                PlayerPrefs.SetInt("save", sv);
            }
        }
    }


   
}
