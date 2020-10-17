using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_enemy : player_parameter
{
    public bool go_flag=false;
    public Animator parent_anim;
    private AudioSource audioSource;
    public AudioClip clip;

    private void Start()
    {
        parent_anim = GetComponentInParent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (go_flag)
        {
            audioSource.clip = clip;
            audioSource.Play();
            parent_anim.SetBool("Run", true);
            var rigid = get_rigidbody();
            var transform = get_transform();
            rigid.AddForce(transform.forward * (-1));        
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            go_flag = true;
        }
    }
}
