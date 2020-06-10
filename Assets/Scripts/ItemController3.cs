using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ItemController3 : MonoBehaviour
{
    public GameObject get;
    BarrierSystem barrierSystem;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject,10.0f);
        barrierSystem = GameObject.Find("BarrierSystem").GetComponent<BarrierSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, 3.8f * Time.deltaTime, 0);
    }

    void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag == "player"){
            Instantiate(get,transform.position,transform.rotation);
            barrierSystem.Barrier();
            Destroy(gameObject);
        }
    }

}
