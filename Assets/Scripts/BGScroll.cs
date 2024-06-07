using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    private MeshRenderer msh;
    public float speed = 0.5f;
    private void Awake()
    {
        msh = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
       Vector2 Offset =new Vector2(0f,Time.time * speed);
        msh.material.mainTextureOffset = Offset;
    }
}
