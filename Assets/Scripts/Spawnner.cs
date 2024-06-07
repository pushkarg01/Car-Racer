using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawnner : MonoBehaviour
{
    public GameObject[] enemies;

    public float min_x = -2.5f, max_x = 2.5f;

    public float delayTime = 0.5f;
    private float timer;
    // Update is called once per frame
    void Update()
    {
        timer-=Time.deltaTime;
        if(timer <= 0)
        {
            Vector3 temp = transform.position;
            temp.x =Random.Range(min_x,max_x);

            int rand =Random.Range(0,enemies.Length);
            Instantiate(enemies[rand],temp, enemies[rand].transform.rotation);

            timer = delayTime;
        }
    }

    
}
