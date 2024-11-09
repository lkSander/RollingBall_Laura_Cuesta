using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    
    [SerializeField] AudioSource audioSourceSfx;
   
    public void ReproducirSonido(AudioClip clip)
    {
        //1Vez
        audioSourceSfx.PlayOneShot(clip);
    }

    //If 
}
