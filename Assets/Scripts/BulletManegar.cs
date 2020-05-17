using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManegar : MonoBehaviour
{
    
    

    // Update is called once per frame
    void Update()
    {   //弾の移動
        transform.position += new Vector3(0,0.1f,0);

        //弾の削除
        if (transform.position.y > 5) {
			Destroy (gameObject);
        }
    }
}
