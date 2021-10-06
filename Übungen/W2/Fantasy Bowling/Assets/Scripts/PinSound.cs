using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSound : MonoBehaviour
{
    private AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name != "Cube") {
            _audioSource.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
