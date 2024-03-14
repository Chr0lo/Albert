using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventThree : MonoBehaviour
{

    public GameObject gravity;
    public GameObject txt1;
    public GameObject txt2;
    public GameObject spaceAbberation;
    public GameObject canon;
    public Animation anim;

    public GameObject txt3;
    public GameObject txt4;
    // Start is called before the first frame update
    void Start()
    {
        gravity.SetActive(true);
        canon.SetActive(true);
        txt1.SetActive(false);
        txt2.SetActive(true);
        txt3.SetActive(true);
        txt4.SetActive(true);
        StartCoroutine(Str());
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator Str()
    {
        yield return new WaitForSeconds(3f);
        
        spaceAbberation.SetActive(true);
        anim.Play();

    }
}
