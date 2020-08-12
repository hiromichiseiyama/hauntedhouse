using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(BoxCollider))]

public class fall_door : MonoBehaviour
{
    [SerializeField]
    private GameObject audio_object;    /*オーディオソースがアタッチされているゲームオブジェクト*/
    [SerializeField]
    private AudioClip fall_sound;
    private AudioSource audioSource;
    private Animation door_anim;

    private void Start()
    {
        audioSource = audio_object.GetComponent<AudioSource>();
        door_anim = GetComponent<Animation>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            door_anim.Play();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            audioSource.clip = fall_sound;
            audioSource.Play();
        }
    }
}
