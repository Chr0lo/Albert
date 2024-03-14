using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventOne : MonoBehaviour
{

    public GameObject gravityBoss;
    public GameObject txt1;
    public GameObject txt2;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Str());
        txt1.SetActive(false);
        txt2.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator Str()
    {
        yield return new WaitForSeconds(3f);
        gravityBoss.SetActive(true);
        
    }
}
