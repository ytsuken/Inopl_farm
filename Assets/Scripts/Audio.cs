using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    public AudioSource audiosource;

    public void off()
    {
        AudioListener.volume = 0;
    }
    public void on()
    {
        AudioListener.volume = 1;
    }


}