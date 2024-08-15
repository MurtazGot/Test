using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCrowdController : MonoBehaviour
{
   [SerializeField] private Texture[] _woomanAniTex;
    [SerializeField] private Texture[] _albedo;
    void Start()
    {
        var meshRenders = GetComponentsInChildren<MeshRenderer>();
        foreach (var m in meshRenders)
        {
            m.material.SetTexture("_AnimationTex",_woomanAniTex[Random.Range(0,_woomanAniTex.Length)]);
            m.material.SetTexture("_Albedo",_albedo[Random.Range(0,_albedo.Length)]);
            m.material.SetFloat("_Framerate", Random.Range(45f,75f));
            m.transform.eulerAngles += new Vector3(0, Random.Range(-180f, 180f));
        }
    }

    
}
