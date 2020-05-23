using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEscript : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision){
    
        if (collision.gameObject.tag == "bullet"){
            audioSource.PlayOneShot(sound1);
        }

    }
}
