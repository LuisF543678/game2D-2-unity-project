using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScroller : MonoBehaviour
{
    public float scrollerSpeed = 0.9f;
    private MeshRenderer renderer;
    [SerializeField] private MeshRenderer mesh;
    
    void Update()
    {
        Vector2 offset = new Vector2(0, Time.time * scrollerSpeed);
        mesh.material.mainTextureOffset = offset;
    }
}
