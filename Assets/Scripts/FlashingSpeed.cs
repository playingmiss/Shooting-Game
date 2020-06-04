using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashingSpeed : Flashing
{
    // Update is called once per frame
    public override void Update()
    {
        if(item_vanish){
            level = Mathf.Abs(Mathf.Sin(Time.time * 10));
            gameObject.GetComponent<SpriteRenderer> ().color =  new Color(1f,150f/255f,220f/255f,level);//R=255,G=150,B=220,Alpha=level
        }
    }
}
