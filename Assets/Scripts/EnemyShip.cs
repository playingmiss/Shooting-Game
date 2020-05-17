using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //敵の移動
        transform.position -= new Vector3 (0,0.1f,0);

        if (transform.position.y < -7) {
			Destroy (gameObject);
        }
    }
}
