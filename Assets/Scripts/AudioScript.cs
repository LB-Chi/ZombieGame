using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioScript : MonoBehaviour
{
    public AudioSource AudioSource;
    private float musicVolume = 1f;

    // Start is called before the first frame update
    void Start()
    {
        AudioSource.Play();
    }

    void Update()
    {
        AudioSource.volume = musicVolume;
    }

    public void ChangeVolume (float volume)
    {
        musicVolume = volume;
    }

}
