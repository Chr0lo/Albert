using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityHit : MonoBehaviour
{

    public Animator gravityMonster;
    public GameObject cube;
    public gravityBoom poc;
    


    public void Update()
    {
        
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
       

        if (collision.gameObject.CompareTag("Player"))
        {
            gravityMonster.SetBool("hit", true);
            
            StartCoroutine(animFalse());

        }
    }


    IEnumerator animFalse()
    {
        yield return new WaitForSeconds(1f);
        gravityMonster.SetBool("hit", false);
        poc.onHit();
        cube.SetActive(false);

    }
}
