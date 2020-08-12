using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onoff : MonoBehaviour
{
    [SerializeField]
    public GameObject canvas;
    [SerializeField]
    public GameObject helper;

    void Update()
    {
        if (OVRInput.Get(OVRInput.RawButton.RThumbstick))
        {
            canvas.gameObject.SetActive(true);
            helper.gameObject.SetActive(true);
        }

        if (OVRInput.Get(OVRInput.RawButton.LThumbstick))
        {
            canvas.gameObject.SetActive(false);
            helper.gameObject.SetActive(false);
        }
    }
}
