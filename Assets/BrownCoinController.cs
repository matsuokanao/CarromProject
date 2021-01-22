using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownCoinController : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        //tagがgoalの場合、gameObjを削除する
        if (collider.gameObject.tag == "goal" && this.gameObject.CompareTag("brown"))
        {
            //Score クラスの score 変数に +1 点する
            Score.score++;
            //削除
            Destroy(gameObject);

        }
    }
}
