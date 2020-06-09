using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShip : MonoBehaviour
{
    public GameObject GameClearText;
    public ScoreCounter gamecontroller;
    public BGMController bgmcontroller;//追加
    public GameObject explosion;//破壊のプレふぁぶ
    public GameObject explosion2;//自機の爆発
    public HPbar bar;//HPバー
    public static int gameoverflag = 0;//ゲームオーバーフラグ
    public static int clearflag = 0;//ボスクリアフラグ
    float x = 1;//ボスのHP
    bool m_xPlus = true;
    bool m_yPlus = true;
    bool m_Plus = true;
    bool SE_flag = false;//SEフラグ.追加1

    // Start is called before the first frame update
    void Start()
    {
        gameoverflag = 0;//ゲームオーバーフラグを初期化する
        clearflag = 0;//クリアフラグを初期化する
        ScoreCounter.not_Boss = false;//最初からボスをする時にする必要がある.テストのためにも.
        gamecontroller = GameObject.Find("GameController").GetComponent<ScoreCounter>();
        bgmcontroller = GameObject.Find("Audio Source").GetComponent<BGMController>();//追加
        bar = GameObject.Find("HPbar").GetComponent<HPbar>();//HPバーのオブジェクトからHPbarスクリプトをFindする.
        GameClearText.SetActive(false);
    }

    // Update is called once per frame
   void Update () {
        if(!SE_flag){//追加2
　　    if(m_Plus){
            if( m_xPlus ) {
                transform.position += new Vector3(2f*Time.deltaTime, 0f, 0f);
                if( transform.position.x >= 4 )
                    m_xPlus = false;
            } else {
                transform.position -= new Vector3(2f*Time.deltaTime, 0f, 0f);
                if( transform.position.x <= -4 )//{}を付けてみる
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
                if( transform.position.y >= 4 )//{}を付けてみる
                    m_yPlus = true;
                    m_Plus = true;
            }
        }
        }
       
    }
    //当たり判定
    void OnTriggerEnter2D(Collider2D collision){
   
        if (collision.gameObject.tag == "bullet2" && gameoverflag == 0){//ゲームオーバーではない時のみダメージが通る
            if(x!=0){
                Instantiate(explosion,collision.transform.position,collision.transform.rotation);
                x--;
                bar.HPdecrease(x);
                Destroy(collision.gameObject);
            }
            if(x==0 && SE_flag == false){//追加3
                SE_flag = true;//追加4
                clearflag = 1;//クリアフラグを立てる.
                Destroy(collision.gameObject);
                StartCoroutine("ManySE");//追加5
                //ScoreCounter.not_Boss = true;//テスト用
            }

        }

        if (collision.gameObject.tag == "player" && BarrierSystem.barrier == 0){
            Debug.Log("やられた");
            gameoverflag = 1;//ゲームオーバーフラグを立てる
            Instantiate(explosion2,collision.transform.position,collision.transform.rotation);
            gamecontroller.GameOver();
            Destroy(collision.gameObject);
            ScoreCounter.not_Boss = true;//ボスでやられたときにする必要がある
        }

    }

    IEnumerator ManySE(){//追加6
        bgmcontroller.StopBGM();//追加
        BarrierSystem.barrier = 1;
        int i = 20;
        for(int j =0;j<i;j++){
            float x = Random.Range(-2f,2f);
            float y = Random.Range(-2f,2f);
            Vector3 vec = new Vector3(x,y,0); 
            yield return new WaitForSeconds(0.15f);
            Instantiate(explosion,vec+transform.position,transform.rotation);
        }
        yield return new WaitForSeconds(0.25f);
        Instantiate(explosion,transform.position,transform.rotation);
        GameClearText.SetActive(true);
        Destroy(gameObject);
        

    }
  
}
