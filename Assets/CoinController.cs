using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{

    private void OnTriggerEnter(Collider collider)
    {
        //tagがgoalの場合、gameObjを削除する
        if(collider.gameObject.tag == "goal")
        {
            //削除
            Destroy(gameObject);
        }
    }
}
