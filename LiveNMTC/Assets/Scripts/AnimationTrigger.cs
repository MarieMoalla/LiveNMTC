using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    public Animator anim;
    private int click = 0;

    public void OnActivate()
    {
        click++;
        if(click % 2 != 0)
        {        
            Debug.Log("Active!");
            anim.SetBool("Active", true);
        }
        else
        {
        Debug.Log("Not Active!");
        anim.SetBool("Active", false);
        }
    }

}
