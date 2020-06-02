using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator3 : MonoBehaviour
{
    public GameObject enemy4;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",2f,0.2f);
    }

    void Spawn(){
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
