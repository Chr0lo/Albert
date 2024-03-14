using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AlbertMovement : MonoBehaviour
{
    public AlbertController controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;

    public bool jump = false;

    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        anim.SetFloat("speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            
        }

        
        
          if(controller.m_Grounded == true)
        {
            anim.SetBool("jump", false);
        }else if (controller.m_Grounded == false)
        {
            anim.SetBool("jump", true);

        }
        
        

    }

   

  



    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
