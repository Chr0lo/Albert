using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class stopAnim : MonoBehaviour
{

    public Animation anim;
    public PostProcessVolume pos;
    public PostProcessVolume pos2;
    // Start is called before the first frame update
    void Start()
    {
        anim.enabled = false;
        pos.weight = 0f;
        pos2.weight = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
