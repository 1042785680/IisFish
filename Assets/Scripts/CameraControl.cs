﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public GameObject followee;
    public float posZ;
    public float[] CameraPositionXRange;
    public float[] CameraPositionYRange;
    
    void Start()
    {
        updatePosition();
    }
    
    void Update()
    {
        updatePosition();
    }

    // 相机跟随鱼
    private void updatePosition()
    {
        Vector3 camNewPos = followee.transform.position + new Vector3(3f, 0, 0);

        // 限制相机范围
        if (camNewPos.x <= CameraPositionXRange[0])
        {
            camNewPos.x = CameraPositionXRange[0];
        }
        if (camNewPos.x >= CameraPositionXRange[1])
        {
            camNewPos.x = CameraPositionXRange[1];
        }

        if (camNewPos.y <= CameraPositionYRange[0])
        {
            camNewPos.y = CameraPositionYRange[0];
        }
        if (camNewPos.y >= CameraPositionYRange[1])
        {
            camNewPos.y = CameraPositionYRange[1];
        }

        camNewPos.z = posZ;
        transform.position = camNewPos;
    }
}
