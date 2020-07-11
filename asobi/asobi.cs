using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asobi : MonoBehaviour
{
    private GameObject player;
    private Animator anim;
    private AudioSource audioSource;
    [SerializeField] private AudioClip clip;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        anim = player.GetComponent<Animator>();
        audioSource = player.GetComponent<AudioSource>();
    }
    void Update()
    {
        
    }

    public void OnClick()
    {
        //audioSource.clip = clip;
        //audioSource.Play();
        
        anim.SetTrigger("isPose");
    }
}
