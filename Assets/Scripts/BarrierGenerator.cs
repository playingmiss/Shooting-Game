using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierGenerator : MonoBehaviour
{
    public GameObject barrierItem;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ItemSpawn", 5f, 2f);
    }

    // Update is called once per frame

    void ItemSpawn()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(-6.5f, 6.5f),
            transform.position.y,
            transform.position.z
        );
        if (Random.Range(0, 1) == 0)
        {
            Instantiate(barrierItem, spawnPosition, transform.rotation);
        }
    }

    void Update()
    {
        
    }
}
