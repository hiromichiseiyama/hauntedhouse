using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laugh : MonoBehaviour
{
    public AudioClip clip;
    private AudioSource audioSource;
    private bool flag=true;
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

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && flag)
        {
            audioSource.Play();
            flag = false;
        }
    }
}
