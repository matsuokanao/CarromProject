using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCoinController : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
      //tagがgoalの場合、gameObjを削除する
       
        if (collider.gameObject.tag == "goal")
        {
            //Score クラスの score 変数に +1 点する
            GreenScore.Greenscore++;
            //削除
            Destroy(gameObject);
        } 
    }
}
