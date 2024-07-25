using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    float minX, maxX;
    [SerializeField] private float padding = 0.8f;


    void Start()
    {
        FindBound();
    }

    void FindBound()
    {
        Camera cam = Camera.main;
        minX = cam.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        maxX = cam.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;
    }

    void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float newXPos = Mathf.Clamp(transform.position.x + deltaX, minX, maxX);
        transform.position = new Vector2(newXPos, transform.position.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        { 
            SceneManager.LoadScene(0);
        }
    }
}
