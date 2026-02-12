using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudiManager : MonoBehaviour
{
    public AudioSource audioData;
     public bool estadoPausa=false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayAudios()
    {
        if(estadoPausa)
        { 
             estadoPausa=false;
            audioData.UnPause();
        }else{
            audioData.Play();
            }
        
         
    }
    public void PauseAudios()
    {    
            estadoPausa=true;
         audioData.Pause();
    }
    public void forwardAudio()
    {
         audioData.time = audioData.time * 1.41f;
    }
}
