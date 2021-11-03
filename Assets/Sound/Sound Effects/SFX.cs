using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource PauseSound;
    public AudioSource Hover;
    public AudioSource Select;
    public AudioSource Back;
    public AudioSource Slider;
    public AudioSource LevelSelect;

    public void PlayPauseSound()
    {
        PauseSound.Play();
    }
    public void PlayHover()
    {
        Hover.Play();
    }
    public void PlaySelect()
    {
        Select.Play();
    }
    public void PlayBack()
    {
        Back.Play();
    }
    public void PlaySlider()
    {
        Slider.Play();
    }
    public void PlayLevelSelect()
    {
        LevelSelect.Play();
    }
}
