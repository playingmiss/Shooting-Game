using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShip : MonoBehaviour
{
    public GameObject GameClearText;
    public ScoreCounter gamecontroller;
    public GameObject explosion;//破壊のプレふぁぶ
    public GameObject explosion2;//自機の爆発
    int x = 1;
    bool m_xPlus = true;
    bool m_yPlus = true;
    bool m_Plus = true;
    //public AudioClip sound1;
    //AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        gamecontroller = GameObject.Find("GameController").GetComponent<ScoreCounter>();
        //audioSource = GetComponent<AudioSource>();
        GameClearText.SetActive(false);
    }

    // Update is called once per frame
   void Update () {
　　    if(m_Plus){
            if( m_xPlus ) {
                transform.position += new Vector3(2f*Time.deltaTime, 0f, 0f);
                if( transform.position.x >= 4 )
                    m_xPlus = false;
            } else {
                transform.position -= new Vector3(2f*Time.deltaTime, 0f, 0f);
                if( transform.position.x <= -4 )
                    m_xPlus = true;
                    m_Plus = false;
            }
       }else{
            if( m_yPlus ) {
                transform.position -= new Vector3(0,2*Time.deltaTime, 0f);
                if( transform.position.y <= -4 )
                    m_yPlus = false;
            }   else {
                transform.position += new Vector3(0f,2*Time.deltaTime,0f);
                if( transform.position.y >= 4 )
                    m_yPlus = true;
                    m_Plus = true;
            }
        }
       
    }
    //当たり判定
    void OnTriggerEnter2D(Collider2D collision){
   
        if (collision.gameObject.tag == "bullet2"){
           
            Instantiate(explosion,collision.transform.position,collision.transform.rotation);
            x--;
            if(x==0){
                Destroy(gameObject);
                Destroy(collision.gameObject);
                gamecontroller.addscore();
                BarrierSystem.barrier = 1;
                GameClearText.SetActive(true);
            }

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
