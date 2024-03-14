using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityMonsterControl : MonoBehaviour
{

    public GameObject objectContainingScripts;
    public string[] scriptNamesToActivate;
    private MonoBehaviour[] allScripts;
    private MonoBehaviour currentActiveScript;
    public Animator pins;

    public float minActivationTime = 5f;
    public float maxActivationTime = 10f;

    void Start()
    {
        // Obține toate scripturile din obiectul specificat
        allScripts = objectContainingScripts.GetComponents<MonoBehaviour>();

        StartCoroutine(ActivateScripts());
    }

    IEnumerator ActivateScripts()
    {
        while (true)
        {
            // Așteaptă un interval de timp aleator între minActivationTime și maxActivationTime
            yield return new WaitForSeconds(Random.Range(minActivationTime, maxActivationTime));

            // Dezactivează scriptul curent (dacă există)
            if (currentActiveScript != null)
            {
                currentActiveScript.enabled = false;
                
            }
            pins.SetBool("fast", true);
            StartCoroutine(fastFalse());

            // Activează un script aleatoriu din cele disponibile
            currentActiveScript = GetRandomScript();
            currentActiveScript.enabled = true;
            
        }
    }

    MonoBehaviour GetRandomScript()
    {
        // Creează o listă de nume de scripturi disponibile pentru a selecta aleatoriu
        List<string> availableScriptNames = new List<string>(scriptNamesToActivate);

        // Excludem numele scriptului curent pentru a evita reactivarea lui
        if (currentActiveScript != null)
        {
            string currentScriptName = currentActiveScript.GetType().Name;
            availableScriptNames.Remove(currentScriptName);
        }

        // Selectează aleatoriu unul dintre numele de scripturi disponibile
        int randomIndex = Random.Range(0, availableScriptNames.Count);



        // Găsește scriptul corespunzător numele selectat
        foreach (MonoBehaviour script in allScripts)
        {
            if (script.GetType().Name == availableScriptNames[randomIndex])
            {
                return script;
            }
        }

        return null;
    }

    IEnumerator fastFalse()
    {
        yield return new WaitForSeconds(0.5f);
        pins.SetBool("fast", false);
    }
}
