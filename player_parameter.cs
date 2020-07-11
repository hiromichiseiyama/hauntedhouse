﻿using Oculus.Platform.Samples.VrHoops;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_parameter : MonoBehaviour
{
    [SerializeField]private GameObject player;

    private void Update()
    {
        player = GetComponent<GameObject>();
    }

    public GameObject get_gameobject()
    {
        return player.gameObject;
    }

    public Transform get_transform()
    {
        return player.gameObject.transform;
    }

    public Rigidbody get_rigidbody()
    {
        return player.GetComponent<Rigidbody>();
    }
}
