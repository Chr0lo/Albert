using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShokScript : MonoBehaviour
{
    public GameObject shockWavePrefab;
    public float waveDuration = 1f; 

    void Update()
    {
        
    }

    public void onShock()
    {
        Vector3 clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        clickPos.z = 0;
        GameObject shockWave = Instantiate(shockWavePrefab, clickPos, Quaternion.identity);
        Destroy(shockWave, waveDuration);
    }
}
