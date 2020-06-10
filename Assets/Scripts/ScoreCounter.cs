using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    public GameObject GameOverText;
    public GameObject GameClearText;
    public Text scoreText ;
    public static int score = 0;//ゲームスコア
    public int scenescore = 0;//シーン内スコア
    Scene activescene;//アクティブなシーンを代入
    public static bool not_Boss = true;
    public static bool stage1 = true;//追加
    public static bool stage2 = false;//追加
    public static bool stage3 = false;//追加

    // Start is called before the first frame update
    void Start()
    {
      activescene = SceneManager.GetActiveScene();//GetActiveScene()でアクティブなシーンを獲得
      GameOverText.SetActive(false);  
      GameClearText.SetActive(false); 
      scoreText.text = "SCORE:" + score;  
    }

    public void addscore(){
        if(GameOverText.activeSelf == false){//もしゲームオーバーでなければ           
            score += 100;
            scenescore += 100;
            scoreText.text = "SCORE:" + score;
            if(not_Boss == true ){
                if((stage1==true)&&(scenescore >= 3000)){//変更
                    BarrierSystem.barrier = 1;
                    GameClearText.SetActive(true);
                    StartCoroutine("SceneChange");
                }
                if((stage2==true)&&(scenescore >= 10000)){//追加
                    BarrierSystem.barrier = 1;
                    GameClearText.SetActive(true);
                    StartCoroutine("SceneChange");
                }
                if((stage3==true)&&(scenescore >= 2000)){//追加
                    BarrierSystem.barrier = 1;
                    GameClearText.SetActive(true);
                    StartCoroutine("SceneChange");
                }

            }
        }
    }
    

    // Update is called once per frame
    public void GameOver(){
        GameOverText.SetActive(true);
    }
    void Update()
    {
        if(GameOverText.activeSelf == true){//ゲームオーバーテキストがアクティブの時...
            if(Input.GetKeyDown(KeyCode.Space)){
                score = 0;
                not_Boss = true;
                SceneManager.LoadScene("unity_shoot_22");
            }
        }
    }

    IEnumerator SceneChange()
    {
        yield return new WaitForSeconds(3);
        BarrierSystem.barrier = 0;
        switch (activescene.name)
        {
            case "unity_shoot_22":
                SceneManager.LoadScene("unity_shoot_3");
                stage1 = false;//追加
                stage2 = true;
                break;
            case "unity_shoot_3":
                SceneManager.LoadScene("unity_shoot_2");
                stage2 = false;//追加
                stage3 =true;
                break;
            case "unity_shoot_2":
                SceneManager.LoadScene("BossStage");
                stage3 = false;//追加
                not_Boss = false;
                break;
            default:
                Debug.Log("Default");
                break;
        }
    }
}
