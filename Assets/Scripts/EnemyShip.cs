using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


public class EnemyShip : MonoBehaviour
{
    public ScoreCounter gamecontroller;
    public GameObject explosion;//破壊のプレふぁぶ
    public GameObject explosion2;//自機の爆発

    // Start is called before the first frame update
    void Start()
    {
        gamecontroller = GameObject.Find("GameController").GetComponent<ScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {   //敵の移動
        transform.position -= new Vector3 (0,4*Time.deltaTime,0);

        if (transform.position.y < -7) {
			Destroy (gameObject);
        }
    }
    //当たり判定
    void OnTriggerEnter2D(Collider2D collision){
   
        if ((collision.gameObject.tag == "bullet")||(collision.gameObject.tag == "bullet2")){
            Instantiate(explosion,transform.position,transform.rotation);
            
            Destroy(gameObject);
            Destroy(collision.gameObject);
            gamecontroller.addscore();

        }       

        if (collision.gameObject.tag == "player" && BarrierSystem.barrier == 0){
            Instantiate(explosion2,transform.position,transform.rotation);
            Debug.Log("Game Over");
            gamecontroller.GameOver();
            Destroy(collision.gameObject);
        }

    }

    
}
