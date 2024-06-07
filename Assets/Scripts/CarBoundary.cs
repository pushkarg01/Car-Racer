using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarBoundary : MonoBehaviour
{
    
    public float min_x = -2.6f, max_x = 2.6f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        CheckBound();
    }

    void CheckBound()
    {
        Vector2 temp = rb.transform.position;
        if (temp.x >= max_x)
        {
            temp.x = max_x;
        }

        if (temp.x <= min_x)
        { temp.x = min_x; }

       rb.transform.position = temp;

        
    }

}
