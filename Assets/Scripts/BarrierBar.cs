using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class BarrierBar : MonoBehaviour
{
    // Start is called before the first frame update
    Slider _slider;
    BarrierSystem _barrier;
    float barrierBar = 0;
    void Start()
    {
        // スライダーを取得する
        _slider = GameObject.Find("Slider").GetComponent<Slider>();
        _barrier = GameObject.Find("BarrierSystem").GetComponent<BarrierSystem>();
    }

    
    void Update()
    {
        if (BarrierSystem.barrier == 1)
        {
            Debug.Log(_barrier.duration);
            barrierBar = 1.0f - ((float)_barrier.duration / 5000);
            
        }
        else barrierBar = 0;

        _slider.value = barrierBar;
        
    }

}
