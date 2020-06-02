using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombBulletController : MonoBehaviour
{

    static int i=0;
    public float[] angle = {0,45,90,135,180,225,270,315};
    public Vector3 velocity = new Vector3(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
        Vector3 direction = new Vector3(Mathf.Cos(angle[i]*Mathf.Deg2Rad),Mathf.Sin(angle[i]*Mathf.Deg2Rad),0);//角度計算
        velocity = direction * 0.1f;
        i++;
        if(i==8) i=0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity;
        Debug.Log(velocity);
        Destroy(gameObject,2f);
        
    }

}
