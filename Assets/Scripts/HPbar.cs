using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    Slider _slider;
    float _hp = 0;
    int hp_flag = 0;

    // Start is called before the first frame update
    void Start()
    {
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hp_flag == 0){
            _hp += 0.01f;
            if(_hp <= 1){
                _slider.value = _hp;
            }
            if(_hp == 1)
                hp_flag = 1;
        }
    }

    public void HPdecrease(float hp){
        hp /= 20;
        _slider.value = hp;
    }

}
