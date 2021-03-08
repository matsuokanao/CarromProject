using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // ClearUIのGameObject型変数
    public GameObject clearUi;
    private Striker striker;
    
    void Start()
    {
       // ゲームを再生するとClearUIを非表示にする
        clearUi.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (striker.playerTurn == false) {
            // ClearUIを表示する
            clearUi.SetActive(true);
        }
    }
}
