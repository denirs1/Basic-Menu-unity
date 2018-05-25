using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class volumechange : MonoBehaviour
{
    public Slider sliderv;
    AudioSource source;
    

   public void Start()
    {
        //start and play for music
        AudioListener.volume = 0;
        source = GetComponent<AudioSource>();
        source.Play();
    }
   
   public void update( )
    {//volume for music
        AudioListener.volume = sliderv.value;

    }
}