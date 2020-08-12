using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]

public class self_destroy : MonoBehaviour
{
    private void Update()
    {
        float y = this.transform.position.y;

        if (y < -20)
        {
            Destroy(this.gameObject);
        }
    }
}
