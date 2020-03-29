using UnityEngine;
using System.Collections;

public class audio2script : MonoBehaviour {

    public AudioClip SoundToPlay;
    public float Volume;
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    
}

