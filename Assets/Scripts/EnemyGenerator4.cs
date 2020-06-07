using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator4 : MonoBehaviour
{
    public GameObject enemy4;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",2f,0.6f);
    }

    void Spawn(){
        Vector3 spawnPosition = new Vector3(
            Random.Range(-6.5f,6.5f),
            transform.position.y,
            transform.position.z
        );
        if(BossShip.clearflag == 0)//BossShipのクリアフラグが立っていなければ
            Instantiate(enemy4,spawnPosition,transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
