using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuContinue : MonoBehaviour
{

    public int menu;

    public GameObject b1;   
    public GameObject b2;

    // Start is called before the first frame update
    void Start()
    {
        menu = PlayerPrefs.GetInt("menu");
    }

    // Update is called once per frame
    void Update()
    {
        if(menu == 1)
        {
            b1.SetActive(false);
            b2.SetActive(true);
        }
        else
        {
            b1.SetActive(true);
            b2.SetActive(false);
        }
    }


    public void onPl()
    {
        PlayerPrefs.SetInt("menu", 1);
    }

    public void onQuit()
    {
        Application.Quit();
    }
}
