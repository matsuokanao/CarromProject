using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    private Text scoreText;

    void Start()
    {
       // 自分自身に付いているTextポーネントを参照
        scoreText = GetComponent<Text>();
    }

    void Update()
    {
        // スコアの表更新
            scoreText.text = "Score:" + score.ToString();
            //削除
            Destroy(gameObject);

    }
}
