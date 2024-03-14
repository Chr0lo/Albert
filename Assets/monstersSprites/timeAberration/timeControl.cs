using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeControl : MonoBehaviour
{
    private float minTimeScale = 0.3f;
    private float maxTimeScale = 2f;
    private float changeInterval = 3f;
    private float timer = 0f;

    void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= changeInterval)
        {
            timer = 0f;
            float randomTimeScale = Random.Range(minTimeScale, maxTimeScale);
            Time.timeScale = randomTimeScale;
        }
    }
}
