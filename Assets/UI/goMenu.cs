using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goMenu : MonoBehaviour
{


    public string lvl;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Ongomen()
    {
        Application.LoadLevel(lvl);

    }
}
