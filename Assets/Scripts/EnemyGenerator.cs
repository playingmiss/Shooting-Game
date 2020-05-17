using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        //繰り返し敵の生成
        InvokeRepeating("Spawn",2f,0.7f);　//Spawnを2秒後に0.5刻み
    }
    //敵の生成
    void Spawn(){

        Vector3 spawnPosition = new Vector3(
            Random.Range(-6.5f,6.5f),
            transform.position.y,
            transform.position.z
        );
        Instantiate(enemy,spawnPosition,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
