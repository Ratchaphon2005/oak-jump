using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudio : MonoBehaviour
{
    public AudioSource audioSource;
    public void playSound(){
        audioSource.Play();
    }
}
