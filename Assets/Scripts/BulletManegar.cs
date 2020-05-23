using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManegar : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;
    
    

    // Update is called once per frame
    void Update()
    {   //弾の移動
        transform.position += new Vector3(0,0.1f,0);

        //弾の削除
        if (transform.position.y > 5) {
			Destroy (gameObject);
        }
    }

   //void OnTriggerEnter2D(Collider2D collision){
        //    audioSource.PlayOneShot(sound1);

   // }

}
