﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPerspectives : MonoBehaviour
{
    public Camera[] cameras = new Camera[4];
    public bool changeAudioListener = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            EnableSwitch(cameras[0], true);
            EnableSwitch(cameras[1], false);
            EnableSwitch(cameras[2], false);
            EnableSwitch(cameras[3], false);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            EnableSwitch(cameras[0], false);
            EnableSwitch(cameras[1], true);
            EnableSwitch(cameras[2], false);
            EnableSwitch(cameras[3], false);
        }

        else if (Input.GetKeyDown(KeyCode.H))
        {
            EnableSwitch(cameras[0], false);
            EnableSwitch(cameras[1], false);
            EnableSwitch(cameras[2], true);
            EnableSwitch(cameras[3], false);
        }

        else if (Input.GetKeyDown(KeyCode.J))
        {
            EnableSwitch(cameras[0], false);
            EnableSwitch(cameras[1], false);
            EnableSwitch(cameras[2], false);
            EnableSwitch(cameras[3], true);
        }
    }

    void EnableSwitch(Camera cam, bool enable)
    {
        cam.enabled = enable;

        if (changeAudioListener)
        {
            cam.GetComponent<AudioListener>().enabled = enable;
        }
    }
}
