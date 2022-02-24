using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour
{
    public Transform MainCamera;

    private void LateUpdate()
    {
        Vector3 newPosition = MainCamera.position;
        transform.position = newPosition;
    }
}