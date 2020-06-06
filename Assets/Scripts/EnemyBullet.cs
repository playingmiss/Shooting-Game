using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public GameObject explosion;//自機の破壊
    public ScoreCounter gamecontroller;
    // Start is called before the first frame update
    void Start()
    {
        gamecontroller = GameObject.Find("GameController").GetComponent<ScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0,0.2f,0);
        if (transform.position.y < -7) {
			Destroy (gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
            if (collision.gameObject.tag == "player" && BarrierSystem.barrier == 0){
                Instantiate(explosion,transform.position,transform.rotation);
                Debug.Log("Game Over");
                gamecontroller.GameOver();
                Destroy(collision.gameObject);
                Destroy(gameObject);
        }
    }
}
