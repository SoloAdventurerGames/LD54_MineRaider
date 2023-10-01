using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundSettings : MonoBehaviour
{
    public AudioMixer audio_Mixer;
    
    
    private void Start()
    {
        
    }
    public void SetVolume (float volume)
    {

        audio_Mixer.SetFloat("MasterVolume", Mathf.Log10(volume) * 20);
    }
}
