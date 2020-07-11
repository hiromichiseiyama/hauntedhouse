using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_enemy : player_parameter
{
    private bool go_flag=false;
    private Animator parent_anim;

    private void Start()
    {
        parent_anim = GetComponentInParent<Animator>();
    }

    private void Update()
    {
        if (go_flag)
        {
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
