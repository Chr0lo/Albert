using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityControl : MonoBehaviour
{

    public AlbertGravity grav;

    


    public void OnGround()
    {
        grav.gravity = 0;
    }

    public void OnCeiling()
    {
        grav.gravity = 1;
    }

    public void OnRight()
    {
        grav.gravity = 2;
    }

    public void OnLeft()
    {
        grav.gravity = 3;
    }
}
