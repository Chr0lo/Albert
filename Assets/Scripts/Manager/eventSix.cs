using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventSix : MonoBehaviour
{
    public GameObject gravity;
    public GameObject canon;
    public GameObject dash;
    public GameObject txt1;
    public GameObject txt2;
    public GameObject aberration;
    public Animation anim;
    public GameObject bio;
    public GameObject txt3;
    public GameObject txt4;
    public GameObject txt5;
    public GameObject txt6;
    public GameObject txt7;
    public GameObject txt8;
    // Start is called before the first frame update
    void Start()
    {
        gravity.SetActive(true);
        canon.SetActive(true);
        dash.SetActive(true);
        StartCoroutine(Str());
        txt1.SetActive(false);
        txt2.SetActive(true);
        txt3.SetActive(true);
        txt4.SetActive(true);
        txt5.SetActive(true);           
        txt6.SetActive(true);
        txt7.SetActive(true);
        txt8.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator Str()
    {
        yield return new WaitForSeconds(3f);
        
        aberration.SetActive(true);
        bio.SetActive(true);
        anim.Play();

    }
}
