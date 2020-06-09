using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip3 : MonoBehaviour
{
    public ScoreCounter gamecontroller;
    public GameObject enemybullet;
    public GameObject explosion;
    public GameObject explosion2;
    //public GameObject bomb_item;//ボムアイテム
    int flag = 0;

    // Start is called before the first frame update
    void Start()
    {
        gamecontroller = GameObject.Find("GameController").GetComponent<ScoreCounter>();
    }


    // Update is called once per frame
    void Update()
    {

        transform.position -= new Vector3 (0,4.5f*Time.deltaTime,0);
        if(transform.position.y < 3 && flag == 0){
            Instantiate(enemybullet, transform.position, transform.rotation);
            flag = 1;

        }
        if (transform.position.y < -7) {
			Destroy (gameObject);
        }

    }




    void OnTriggerEnter2D(Collider2D collision){
        if ((collision.gameObject.tag == "bullet")||(collision.gameObject.tag == "bullet2")){
            //audioSource.PlayOneShot(sound1);
            Instantiate(explosion,transform.position,transform.rotation);
            //if(Random.Range(0,10) <= 3)
            //    Instantiate(bomb_item,transform.position,transform.rotation);
            
            Destroy(gameObject);
            Destroy(collision.gameObject);
            gamecontroller.addscore();
        }
        if (collision.gameObject.tag == "player" && BarrierSystem.barrier == 0)
        {
            Instantiate(explosion2,transform.position,transform.rotation);
            Debug.Log("Game Over");
            gamecontroller.GameOver();
            Destroy(collision.gameObject);
        }
    }
}
