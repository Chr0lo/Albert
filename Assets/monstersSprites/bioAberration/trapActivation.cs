using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapActivation : MonoBehaviour
{
    public GameObject[] objectsToActivate; 

    void Start()
    {
        StartCoroutine(ActivateRandomObjectsCoroutine());
    }

    IEnumerator ActivateRandomObjectsCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(3.1f, 4f)); 

            int numObjectsToActivate = Random.Range(6, 12); 

            for (int i = 0; i < numObjectsToActivate; i++)
            {
                int randomIndex = Random.Range(0, objectsToActivate.Length); 
                GameObject objectToActivate = objectsToActivate[randomIndex]; 
                objectToActivate.SetActive(true); 

                StartCoroutine(DeactivateObjectAfterDelay(objectToActivate, 3f)); 
            }
        }
    }

    IEnumerator DeactivateObjectAfterDelay(GameObject obj, float delay)
    {
        yield return new WaitForSeconds(delay); 
        obj.SetActive(false); 
    }
}
