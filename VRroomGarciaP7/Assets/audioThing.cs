using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioThing : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip Impact;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.PlayOneShot(Impact);
    }
}
