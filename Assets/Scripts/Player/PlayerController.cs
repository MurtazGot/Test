using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public Action Action1;  
    public UnityAction Action2;  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Alpha1)) Action1?.Invoke();
       else  if (Input.GetKeyDown(KeyCode.Alpha2)) Action2?.Invoke();
    }
}
