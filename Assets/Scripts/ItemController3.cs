using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemController3 : MonoBehaviour
{
    public GameObject get;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag == "player"){
            Instantiate(get,transform.position,transform.rotation);
            BarrierSystem.Barrier();
            Destroy(gameObject);
        }
    }

}
