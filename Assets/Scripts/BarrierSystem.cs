using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class BarrierSystem : MonoBehaviour
{
    public int start;
    public int now;
    public int duration = 0;
    public static int barrier = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        now = DateTime.Now.Hour * 60 *60 * 1000 + DateTime.Now.Minute * 60 * 1000 + 
              DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
        duration = now - start;
        if(duration > 5000) barrier = 0;//5秒間無敵
    }

    public void Barrier(){
        barrier = 1;
        start = DateTime.Now.Hour * 60 *60 * 1000 + DateTime.Now.Minute * 60 * 1000 + 
            DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
    }

}
