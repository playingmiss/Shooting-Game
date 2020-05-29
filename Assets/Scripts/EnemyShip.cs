using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


public class EnemyShip : MonoBehaviour
{
    public ScoreCounter gamecontroller;
    public GameObject explosion;//破壊のプレふぁぶ
    public GameObject explosion2;//自機の爆発

    //public AudioClip sound1;
    //AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        gamecontroller = GameObject.Find("GameController").GetComponent<ScoreCounter>();
        //audioSource = GetComponent<AudioSource>();
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
    
        if (collision.gameObject.tag == "bullet"){
            //audioSource.PlayOneShot(sound1);
            Instantiate(explosion,transform.position,transform.rotation);
            
            Destroy(gameObject);
            Destroy(collision.gameObject);
            gamecontroller.addscore();

            //audioSource.PlayOneShot(sound1);
        }

        if (collision.gameObject.tag == "player"){
            Instantiate(explosion2,transform.position,transform.rotation);
            Debug.Log("Game Over");
            gamecontroller.GameOver();
            Destroy(collision.gameObject);
        }
    }

    
}
