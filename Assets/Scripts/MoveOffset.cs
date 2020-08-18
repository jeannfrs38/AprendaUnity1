using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOffset : MonoBehaviour
{
    private Renderer meshRender;
    private Material currentMaterial;

    public float incrementoOfsset;
    public float speed;
    public float offset;

    public string sortingLayer;
    public int orderInLayer;
    void Start()
    {
        meshRender = GetComponent<MeshRenderer>();
        meshRender.sortingLayerName = sortingLayer;
        meshRender.sortingOrder = orderInLayer;

        currentMaterial = meshRender.material;


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        offset += incrementoOfsset;
        currentMaterial.SetTextureOffset("_MainTex", new Vector2(offset * speed, 0));
    }
}
