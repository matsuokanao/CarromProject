﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenScore : MonoBehaviour
{
   public static int Greenscore;
   private Text GreenscoreText;

    void Start()
    {
        // 自分自身に付いているTextポーネントを参照
        GreenscoreText = GetComponent<Text>();
    }

    void Update()
    {
        // スコアの表更新
        GreenscoreText.text = "Score:" + Greenscore.ToString();
    }
}