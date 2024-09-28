using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallEffect : MonoBehaviour
{
    private AudioSource ballSoundEffect;
    // Start is called before the first frame update
    void Start()
    {
        ballSoundEffect = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null)
        {
            ballSoundEffect.Play();
        }
    }
}
