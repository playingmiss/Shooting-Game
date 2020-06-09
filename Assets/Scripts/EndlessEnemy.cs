using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessEnemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemy2;//アイテム落とす
    public GameObject item1;
    public GameObject enemy3;
    public GameObject enemy4;

    // Start is called before the first frame update
    void Start()
    {
        //繰り返し敵の生成
        InvokeRepeating("Spawn",2f,0.5f);　//Spawnを2秒後に0.5刻み
        InvokeRepeating("Spawn2",1.5f,0.8f);
        InvokeRepeating("Spawn3",2.2f,0.8f);

    }
    void Spawn(){

        Vector3 spawnPosition = new Vector3(
            Random.Range(-6.5f,6.5f),
            transform.position.y,
            transform.position.z
        );
        if (Random.Range (0, 4) == 0) {
            Instantiate(enemy2,spawnPosition,transform.rotation);
        }
        //アイテム生成
//        else if(Random.Range (0, 10) == 2){
//           Instantiate(item1,spawnPosition,transform.rotation);
//        }
        else{
            Instantiate(enemy,spawnPosition,transform.rotation);
        }

    }
    void Spawn2(){
        Vector3 spawnPosition = new Vector3(
            Random.Range(-6.5f,6.5f),
            transform.position.y,
            transform.position.z
        );
        Instantiate(enemy3,spawnPosition,transform.rotation);
    }
    void Spawn3(){
        Vector3 spawnPosition = new Vector3(
            Random.Range(-6.5f,6.5f),
            transform.position.y,
            transform.position.z
        );
        Instantiate(enemy4,spawnPosition,transform.rotation);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
