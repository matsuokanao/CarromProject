using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider collider)
    {
        //tagがgoalの場合、gameObjを削除する
        //TODO かつStrikerのターンだった場合
        if (collider.gameObject.tag == "goal" && this.gameObject.CompareTag("white"))
        {
            //Score クラスの score 変数に +1 点する
            Score.score++;
            //削除
            Destroy(gameObject);
            
        }
    }
}
