using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingBomb : Flashing
{
    // Update is called once per frame
    public override void Update()
    {
        if(item_vanish){
            level = Mathf.Abs(Mathf.Sin(Time.time * 10));
            gameObject.GetComponent<SpriteRenderer> ().color =  new Color(1f,121f/255f,121f/255f,level);//R=255,G=121,B=121,Alpha=level
        }
    }
}
