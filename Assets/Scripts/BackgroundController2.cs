using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate (0, -0.1f, 0);
		if (transform.position.y <= -11.0f) {
		    transform.position = new Vector3 (0, 24f, 0);
        }   
    }
}
