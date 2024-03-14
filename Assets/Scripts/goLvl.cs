using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goLvl : MonoBehaviour
{

    public string level;

    public void onNext()
    {
        StartCoroutine(goNxt());
        PlayerPrefs.DeleteAll();
    }


    IEnumerator goNxt()
    {
        yield return new WaitForSeconds(1.2f);
        Application.LoadLevel(level);
    }
}
