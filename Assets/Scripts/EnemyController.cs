using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 8f;
    

    void Update()
    {
        Vector3 temp=transform.position;
        temp.y-=speed*Time.deltaTime;
        transform.position=temp;

        if(transform.position.y < -7f)
        {
            gameObject.SetActive(false);
        }
    }
}
