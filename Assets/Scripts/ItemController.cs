using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    public GameObject get;
    //public GameObject SpeedUpText;
    //public ItemController itemcontroller;
    // Start is called before the first frame update

    void Start()
    {
        Destroy(gameObject,10.0f);
        //InvokeRepeating("Spawn",2f,0.5f);
        //itemcontroller = GameObject.Find("ItemController").GetComponent<ItemController>();
    }

    void Update()
    {   //アイテムの移動
/**    
        transform.position -= new Vector3 (0,4*Time.deltaTime,0);

        if (transform.position.y < -7) {
			Destroy (gameObject);
        }
*/
    }
    //当たり判定
    void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag == "player"){
            //audioSource.PlayOneShot(sound1);
            //Instantiate(explosion,transform.position,transform.rotation);
            Instantiate(get,transform.position,transform.rotation);
            //Instantiate(SpeedUpText,transform.position,transform.rotation);
            Debug.Log("アイテム取得");
            Destroy(gameObject);
            //Destroy(collision.gameObject);
            //itemcontroller.addspeed();
            Player.speed *= 0.97f;
            //speed *= 0.7f;

            //gamecontroller.addscore();

            //audioSource.PlayOneShot(sound1);
        }
    }

/**
    void Spawn(){

        Vector3 spawnPosition = new Vector3(
            Random.Range(-6.5f,6.5f),
            transform.position.y,
            transform.position.z
        );
        if (Random.Range (0, 10) == 0) {
            Instantiate(item1,spawnPosition,transform.rotation);
        }


    }  
*/  

    // Update is called once per frame

}
