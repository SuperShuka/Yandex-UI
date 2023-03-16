using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MaterialManager : MonoBehaviour
{

    public Renderer Renderer;
    private Material _currentMaterial;

    public void SetMaterial()
    {
        Renderer.material = _currentMaterial;
    }

    public void SetMaterial(Material material)
    {
        _currentMaterial = material;
        Renderer.material = material;
    }

}
