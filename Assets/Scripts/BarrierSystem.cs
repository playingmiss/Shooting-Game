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
    ScoreCounter clear;//追加
    // Start is called before the first frame update
    void Start()
    {
        clear = GameObject.Find("GameController").GetComponent<ScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        now = DateTime.Now.Hour * 60 *60 * 1000 + DateTime.Now.Minute * 60 * 1000 + 
              DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
        duration = now - start;
        if(duration > 5000 && clear.clearflag == false) barrier = 0;//5秒間無敵.クリアしている場合,バリアは切れない
    }

    public void Barrier(){
        barrier = 1;
        start = DateTime.Now.Hour * 60 *60 * 1000 + DateTime.Now.Minute * 60 * 1000 + 
            DateTime.Now.Second * 1000 + DateTime.Now.Millisecond;
    }

}
