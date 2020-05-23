using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyShip : MonoBehaviour
{
    public GameObject explosion;//破壊のプレふぁぶ
    public AudioClip sound1;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //敵の移動
        transform.position -= new Vector3 (0,0.05f,0);

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
            //audioSource.PlayOneShot(sound1);
        }

        if (collision.gameObject.tag == "player"){
            Debug.Log("Game Over");
            Destroy(collision.gameObject);
        }
    }

    
}
