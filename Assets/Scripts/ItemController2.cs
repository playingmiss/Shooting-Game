using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController2 : MonoBehaviour
{
    int i= 8;//一度に生成される弾の数
    public GameObject get;
    public GameObject bomb_bullet;

    // Start is called before the first frame update
    void Start()//ボムの設定
    {
        Destroy(gameObject,10.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

   void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag == "player"){
            Instantiate(get,transform.position,transform.rotation);//効果音
            for(int j=0;j<i;j++){
                Instantiate(bomb_bullet,collision.transform.position,collision.transform.rotation);//弾の生成
            }            
            Debug.Log("アイテム取得");
            Destroy(gameObject);

        }
    }

}
