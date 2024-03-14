using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityBoom : MonoBehaviour
{

    public int boom = 0;
    public GameObject dead;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(boom == 4)
        {
            dead.SetActive(true);
        }
    }


    public void onHit()
    {
        boom = boom + 1;
    }
}
