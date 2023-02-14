using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatValueOpen : MonoBehaviour
{
    void Start()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.EnableKeyword("_EMISSION");
        meshRenderer.material.DisableKeyword("_EMISSION");
    }

    public void MatValueOpenChange()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.EnableKeyword("_EMISSION");
    }
}