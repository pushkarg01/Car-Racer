using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private Vector3 myPosition;

 
    void Start()
    {
        myPosition = transform.position;
       
    }

    void Update()
    {
            myPosition.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;

            transform.position = myPosition;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
 
            SceneManager.LoadScene(0);
        }
    }
}
