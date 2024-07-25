using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{
    private Renderer msh;
    public float speed = 0.5f;
    void Awake()
    {
        msh = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
           msh.material.mainTextureOffset = new Vector2(0f, Time.time * speed);
    }
}
