using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{


    public GameObject PauseObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            PauseObj.SetActive(true);
        }
    }



    public void onResume()
    {
        Time.timeScale = 1f;
        PauseObj.SetActive(false);
    }


    public void onMenu()
    {
        Time.timeScale = 1f;
        Application.LoadLevel("Menu");
    }


    public void onTryAgain()
    {
        Time.timeScale = 1f;
        Application.LoadLevel("Level");

    }

}
