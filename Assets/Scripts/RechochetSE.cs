using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RechochetSE : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip sound1;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound1);
        Destroy(gameObject, 1.2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
