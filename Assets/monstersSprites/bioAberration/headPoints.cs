using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headPoints : MonoBehaviour
{
    public int head = 0;
    public GameObject dead;
    public GameObject trap;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (head == 8)
        {
            dead.SetActive(true);
            trap.SetActive(false);
            gameObject.SetActive(false);
        }
    }


    public void onHit()
    {
        head = head + 1;
    }
}
