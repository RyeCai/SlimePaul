using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHighlight : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip hoverFx;

    public void HoverSound()
    {
        myFx.PlayOneShot(hoverFx);
    }
 
}
