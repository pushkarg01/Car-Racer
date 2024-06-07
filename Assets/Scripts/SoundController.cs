using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource takeOff, acc, crash;

    void Start()
    {
        Invoke("TurnOnAcc", 7f);
    }
    public void TurnOnAcc()
    {
        takeOff.Stop();
        acc.Play();
    }
    
}
