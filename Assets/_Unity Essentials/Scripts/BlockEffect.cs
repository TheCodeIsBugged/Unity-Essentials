using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockEffect : MonoBehaviour
{
    private AudioSource blockSoundEffect;
    // Start is called before the first frame update
    void Start()
    {
        blockSoundEffect = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision != null)
        {
            blockSoundEffect.Play();
        }
    }
}
