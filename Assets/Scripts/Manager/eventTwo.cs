using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventTwo : MonoBehaviour
{
    public GameObject gravity;
    public GameObject txt1;
    public GameObject txt2;
    public GameObject txt3;
    public GameObject txt4;
    
    // Start is called before the first frame update
    void Start()
    {
        gravity.SetActive(true);
        StartCoroutine(Str());
        txt1.SetActive(false);
        txt2.SetActive(true);
        txt4.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator Str()
    {
        yield return new WaitForSeconds(25f);
        
        
        txt3.SetActive(true);
    }
}
