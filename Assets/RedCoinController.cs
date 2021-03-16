using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCoinController : MonoBehaviour
{
    GameObject[] objects;
    GameObject[] brownobjects;

    private void OnTriggerEnter(Collider collider)
    {
        objects = GameObject.FindGameObjectsWithTag("white");
        brownobjects = GameObject.FindGameObjectsWithTag("brown");

      //tagがgoalの場合、gameObjを削除する

        if (collider.gameObject.tag == "goal" && GreenGameManager.GreenplayerTurn == true && brownobjects.Length == 0)
        {
            //Score クラスの score 変数に +3 点する
            GreenScore.Greenscore += 3;
            //削除
            Destroy(gameObject);
            
        }
        if (collider.gameObject.tag == "goal" && GameManager.playerTurn == true && objects.Length == 0)
        {
            //Score クラスの score 変数に +3 点する
            Score.score += 3;
            //削除
            Destroy(gameObject);
            
        }
    }
}

