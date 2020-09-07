﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector3 offset;

    void Update()
    {
        transform.position = player.position + offset;
    }
}
