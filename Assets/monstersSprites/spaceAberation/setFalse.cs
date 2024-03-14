using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setFalse : MonoBehaviour
{

    public GameObject obj;
    


    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(objFalse());
    }


    IEnumerator objFalse()
    {
        yield return new WaitForSeconds(1f);
        obj.SetActive(false);
    }
}
