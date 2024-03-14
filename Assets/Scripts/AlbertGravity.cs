using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbertGravity : MonoBehaviour
{
    
    public int gravity = 0;

  

    public GroundWalk ground;
    public RightWalk right;
    public LeftWalk left;
    public CellingWalk ceiling;


    public GameObject dashGround;
    public GameObject dashRight;
    public GameObject dashLeft;
    public GameObject dashCeiling;


    public void Update()
    {
        if(gravity == 0)
        {
            ground.enabled = true;
            dashGround.SetActive(true);
        }
        else
        {
            ground.enabled = false;
            dashGround.SetActive(false);
        }


        if (gravity == 1)
        {
            ceiling.enabled = true;
            dashCeiling.SetActive(true);
        }
        else
        {
            ceiling.enabled = false;
            dashCeiling.SetActive(false);
        }

        if (gravity == 2)
        {
            right.enabled = true;
            dashRight.SetActive(true);
        }
        else
        {
            right.enabled = false;
            dashRight.SetActive(false);
        }

        if (gravity == 3)
        {
            left.enabled = true;
            dashLeft.SetActive(true);
        }
        else
        {
            left.enabled = false;
            dashLeft.SetActive(false);
        }
    }


    
   

}
