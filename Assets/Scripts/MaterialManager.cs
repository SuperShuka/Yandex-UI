using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class MaterialManager : MonoBehaviour
{

    public Renderer renderer;
    public Material _currentMaterial;
    [SerializeField] private BoxCreator _coinBoxCreator;

    private void Start()
    {
        _currentMaterial = renderer.material;
    }

    public void SetMaterial(Material material)
    {
        _currentMaterial = material;
        renderer.material = material;
        _coinBoxCreator.CoinBoxMaterial = material;
    }

}
