using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class go : MonoBehaviour
{
    
    public void onNext()
    {
        StartCoroutine(goNxt());
    }


    IEnumerator goNxt()
    {
        yield return new WaitForSeconds(1.2f);
        Application.LoadLevel("level");
    }
}
