﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreCounter : MonoBehaviour
{
    public Text scoreText ;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
      scoreText.text = "SCORE:" + score;  
    }

    public void addscore(){
        score += 50;
        scoreText.text = "SCORE:" + score;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
