using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMController : MonoBehaviour
{
    public AudioSource source;
    public AudioClip ClearSE;
    // Start is called before the first frame update
    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopBGM(){
        source.Stop();
        StartCoroutine("BossClear");
    }

    IEnumerator BossClear(){
        yield return new WaitForSeconds(5f);
        source.PlayOneShot(ClearSE);
        Destroy(gameObject,8f);
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Endless");
        BarrierSystem.barrier = 0;//テスト用
    }

}
