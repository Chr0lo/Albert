using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityDead : MonoBehaviour
{

    public GameObject gravity;
    public GameObject next;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.parent = null;
        next.SetActive(true);
        gravity.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
