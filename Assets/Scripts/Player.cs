using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
// PlayerBullet プレハブ
public GameObject bullet;
public static float speed=0.5f;
       
public void OnDrag()
    {
        Vector3 TapPos = Input.mousePosition;
        TapPos.z = 10f;
        TapPos.x = Mathf.Clamp(TapPos.x,20,940);
        TapPos.y = Mathf.Clamp(TapPos.y,30,510);
        transform.position = Camera.main.ScreenToWorldPoint(TapPos);
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Shot");
        //弾の発射処理（コルーチン Shot ）を実行
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    //たまの発射処理
    IEnumerator Shot()
    {
        while (true)
        {
            // 弾をプレイヤーと同じ位置/角度で作成
            Instantiate(bullet, transform.position, transform.rotation);
            // 0.5秒待つ
            yield return new WaitForSeconds(speed);
        }
    }

    //アイテムの当たり判定

    void addspeed(){
        speed *= 0.7f;
    }
    /**
    void OnTriggerEnter2D(Collider2D collision){
   
        if (collision.gameObject.tag == "Item1"){
            //audioSource.PlayOneShot(sound1);
            //Instantiate(explosion,transform.position,transform.rotation);
            
            //Destroy(gameObject);
            Destroy(collision.gameObject);
            speed *= 0.7f;
            //gamecontroller.addscore();

            //audioSource.PlayOneShot(sound1);
        }
    */
/**
        if (collision.gameObject.tag == "player"){
            Instantiate(explosion2,transform.position,transform.rotation);
            Debug.Log("Game Over");
            gamecontroller.GameOver();
            Destroy(collision.gameObject);
        }


    }   
*/ 

}
