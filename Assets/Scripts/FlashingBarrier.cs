using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingBarrier : Flashing
{
    // Update is called once per frame
    public override void Update()
    {
        if(item_vanish){
            level = Mathf.Abs(Mathf.Sin(Time.time * 10));
            gameObject.GetComponent<SpriteRenderer> ().color =  new Color(146f/255f,190f/255f,1f,level);//R=146,G=190,B=255,Alpha=level
        }
    }
}

