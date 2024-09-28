using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Narrative : MonoBehaviour
{
    private AudioSource monaLisaNarrative;
    // Start is called before the first frame update
    void Start()
    {
        monaLisaNarrative = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other != null)
        {
            if (other.CompareTag("Player"))
            {
                monaLisaNarrative.Play();
            }
        }
    }
}
