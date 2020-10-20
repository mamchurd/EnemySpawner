using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Footman : MonoBehaviour
{
    [SerializeField] private UnityEvent _pathDone;
    
    public void Init(Material material, Transform parent)
    {
        var footman = Instantiate(this, parent);

        var skinnedMeshRenderer = footman.GetComponentInChildren<SkinnedMeshRenderer>();

        var materials = skinnedMeshRenderer.materials;
        materials[0] = material;

        skinnedMeshRenderer.sharedMaterials = materials;
    }
}
