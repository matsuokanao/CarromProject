using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCoinController : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
      //tagがgoalの場合、gameObjを削除する
       

        if (collider.gameObject.tag == "goal" && GreenGameManager.GreenplayerTurn == true)
        {
            //Score クラスの score 変数に +1 点する
            GreenScore.Greenscore += 3;
            //削除
            Destroy(gameObject);
            
        }
        if (collider.gameObject.tag == "goal" && GameManager.playerTurn == true)
        {
            //Score クラスの score 変数に +1 点する
            Score.score += 3;
            //削除
            Destroy(gameObject);
            
        }
    }
}

