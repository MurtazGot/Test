using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCameraRotation : MonoBehaviour
{
    [SerializeField] private float _speedRotation;
    private Transform _thisTR;
    void Start()
    {
        _thisTR = GetComponent<Transform>();
    }

    private void LateUpdate()
    {
        _thisTR.eulerAngles += new Vector3(0, _speedRotation * Time.deltaTime, 0);
    }
}
