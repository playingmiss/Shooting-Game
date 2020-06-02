using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    public GameObject GameOverText;
    public Text scoreText ;
    int score = 0;
    Scene activescene;//アクティブなシーンを代入

    // Start is called before the first frame update
    void Start()
    {
      activescene = SceneManager.GetActiveScene();//GetActiveScene()でアクティブなシーンを獲得
      GameOverText.SetActive(false);  
      scoreText.text = "SCORE:" + score;  
    }

    public void addscore(){
        score += 50;
        scoreText.text = "SCORE:" + score;
    }
    // Update is called once per frame
    public void GameOver(){
        GameOverText.SetActive(true);
    }
    void Update()
    {
        if(GameOverText.activeSelf == true){//ゲームオーバーテキストがアクティブの時...
            if(Input.GetKeyDown(KeyCode.Space)){
                switch(activescene.name){
                    case "unity_shoot_22":
                        SceneManager.LoadScene("unity_shoot_22");
                        break;
                    case "unity_shoot_2":
                        SceneManager.LoadScene("unity_shoot_2");
                        break;
                    default:
                        Debug.Log("Default");
                        break;
                }
            }
        }
    }
}
