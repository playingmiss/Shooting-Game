using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
// PlayerBullet プレハブ
public GameObject bullet;

public void OnDrag()
    {
        Vector3 TapPos = Input.mousePosition;
        TapPos.z = 10f;
        transform.position = Camera.main.ScreenToWorldPoint(TapPos);
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Shot");
        //弾の発射処理（コルーチン Shot ）を実行
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    //たまの発射処理
    IEnumerator Shot()
    {
        while (true)
        {
            // 弾をプレイヤーと同じ位置/角度で作成
            Instantiate(bullet, transform.position, transform.rotation);
            // 0.05秒待つ
            yield return new WaitForSeconds(0.2f);
        }
    }
}
