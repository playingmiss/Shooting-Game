﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter2 : MonoBehaviour
{
    public GameObject GameOverText;
    public Text scoreText ;
    int score = 0;
    Scene activescene;//アクティブなシーンを代入

    // Start is called before the first frame update
    void Start()
    {
      activescene = SceneManager.GetActiveScene();
      //Debug.Log("Active scene is "+activescene.name+".");//テスト用  
      GameOverText.SetActive(false);  
      scoreText.text = "SCORE:" + score;  
    }

    public void addscore(){
        score += 75;
        scoreText.text = "SCORE:" + score;
    }
    // Update is called once per frame
    public void GameOver(){
        GameOverText.SetActive(true);
    }
    void Update()
    {
        if(GameOverText.activeSelf == true){//ゲームオーバーテキストがアクティブの時...
            if (Input.GetKeyDown(KeyCode.Space)){
                SceneManager.LoadScene("unity_shoot_2");
            }
        }
    }
}
