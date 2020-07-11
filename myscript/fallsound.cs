﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallsound : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = clip;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.Play();
    }
}
        
