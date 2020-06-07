using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_Test : MonoBehaviour
{

    public GameObject explosion;//破壊のプレふぁぶ
    public GameObject explosion2;//自機の爆発
    int SE_flag=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision){
   
        if ((collision.gameObject.tag == "bullet")||(collision.gameObject.tag == "bullet2")){
            if(SE_flag==0){
                SE_flag=1;
                Destroy(collision.gameObject);
                StartCoroutine("ManySE");//たくさんのSEエフェクトを作る
                Instantiate(explosion,transform.position,transform.rotation);
            }
            
            //Destroy(gameObject);
            //Destroy(collision.gameObject);
            //gamecontroller.addscore();


        } 

        if (collision.gameObject.tag == "player" && BarrierSystem.barrier == 0){
            Instantiate(explosion2,transform.position,transform.rotation);
            Debug.Log("Game Over");
            //gamecontroller.GameOver();
            Destroy(collision.gameObject);
        }

    }


    IEnumerator ManySE(){
        int i = 20;
        for(int j =0;j<i;j++){
            float x = Random.Range(-1f,1f);
            float y = Random.Range(-1f,1f);
            Vector3 vec = new Vector3(x,y,0); 
            yield return new WaitForSeconds(0.15f);
            Instantiate(explosion,vec+transform.position,transform.rotation);
        }
        yield return new WaitForSeconds(0.25f);
        Instantiate(explosion,transform.position,transform.rotation);
        Destroy(gameObject);
    }


}
