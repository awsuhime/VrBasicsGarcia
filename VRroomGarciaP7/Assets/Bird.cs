using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Bird : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip[] clips;

    public float chirpStart = 5.0f;
    public float chirpEnd;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
            float chirpLeft = Time.time - chirpStart;
            if (chirpLeft > chirpEnd)
            {
                chirpStart = Time.time;
            audioSource.clip = clips[Random.Range(0, clips.Length)];
            audioSource .Play();
            
            }
        
    }
}
