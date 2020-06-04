using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using DG.Tweening;

public abstract class Flashing : MonoBehaviour {
	
	public bool item_vanish = false; //アイテム消失
    public float level;

	void Start () {
        StartCoroutine("Vanishing");
	}

	public abstract void Update ();

    IEnumerator Vanishing(){
        yield return new WaitForSeconds(7);
        item_vanish = true;
        yield return new WaitForSeconds(3);
        item_vanish = false;
    }

}