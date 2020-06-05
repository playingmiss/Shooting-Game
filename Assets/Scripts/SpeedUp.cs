using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.Color;

public class SpeedUp : MonoBehaviour
{
    public Text SpeedUpText;
    private float fadeOutSpeed = 1f;
    [SerializeField]
    private float moveSpeed = 0.4f;
    // Start is called before the first frame update
    void Start()
    {
        SpeedUpText = GetComponentInChildren<Text>();
    }

    void LateUpdate(){
        transform.rotation = Camera.main.transform.rotation;
        transform.position += Vector3.up * moveSpeed * Time.deltaTime;

        SpeedUpText.color = Color.Lerp(SpeedUpText.color,new Color(1f,0f,0f,0f),fadeOutSpeed * Time.deltaTime);

        if(SpeedUpText.color.a <= 0.1f){
            Destroy(gameObject);
        }
    }

}
