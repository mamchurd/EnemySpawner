using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootmanSpawner : MonoBehaviour
{
    [SerializeField] private Footman _template;
    [SerializeField] private Material _material;

    public void Spawn()
    {
        _template.Init(_material, transform);
    }
}
