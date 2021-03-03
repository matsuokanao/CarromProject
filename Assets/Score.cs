using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int score;
    private Text scoreText;
    public static bool playerTurn;
    private bool turn;

    void Start()
    {
       // 自分自身に付いているTextポーネントを参照
        scoreText = GetComponent<Text>();
        playerTurn = true;

    }

    void Update()
    {
        if (playerTurn == true)
        {
            // スコアの表更新
            scoreText.text = "Score:" + score.ToString();
            //削除
            Destroy(gameObject);

        }

        if(playerTurn == false)
        {
            // スコアの表更新
            scoreText.text = "Score:" + score.ToString();
            //削除
            Destroy(gameObject);
        }
    }
}
