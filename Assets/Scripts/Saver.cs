using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour
{

    public int save;

    public GameObject firstCanv;
    public GameObject one;
    public GameObject second;
    public GameObject third;
    public GameObject fourth;
    public GameObject fifth;
    public GameObject sixth;
   

    // Update is called once per frame
    void Update()
    {
        save = PlayerPrefs.GetInt("save");


        if(save == 0)
        {
            firstCanv.SetActive(true);
        }
        else
        {
            firstCanv.SetActive(false);
        }


        if (save == 1)
        {
            one.SetActive(true);
        }
        else
        {
            one.SetActive(false);
        }

        if (save == 2)
        {
            second.SetActive(true);
        }
        else
        {
            second.SetActive(false);
        }

        if (save == 3)
        {
            third.SetActive(true);
        }
        else
        {
            third.SetActive(false);
        }

        if (save == 4)
        {
            fourth.SetActive(true);
        }
        else
        {
            fourth.SetActive(false);
        }

        if (save == 5)
        {
            fifth.SetActive(true);
        }
        else
        {
            fifth.SetActive(false);
        }

        if (save == 6)
        {
            sixth.SetActive(true);
        }
        else
        {
            sixth.SetActive(false);
        }
    }


    
   
}
