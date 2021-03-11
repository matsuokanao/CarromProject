using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Striker : MonoBehaviour
{
    Rigidbody rigidbody;
    public int strikerSpeed = 50;
    private Vector3 startPosition;
    
    void Start () 
    {
        startPosition = transform.position;
    }

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update(){

       //マウスボタンを押したらÏ
       if (Input.GetMouseButtonDown(0))
          {
         if(GameManager.playerTurn == true){
                //カメラの位置を取得
                Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                //向きの生成（上方向の除去）
                Vector3 shotForward = mouseWorldPos - transform.position;
                shotForward = Vector3.Scale(shotForward, new Vector3(1, 0, 1));
                shotForward = shotForward.normalized;
                //力を加える
                rigidbody.AddForce(shotForward * strikerSpeed);
                Debug.Log(shotForward);
                GameManager.playerTurn = false;
                GreenGameManager.GreenplayerTurn = true;
                Invoke("StartPosition", 3);

         } else if (GreenGameManager.GreenplayerTurn == true){

              //カメラの位置を取得
                Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                //向きの生成（上方向の除去）
                Vector3 shotForward = mouseWorldPos - transform.position;
                shotForward = Vector3.Scale(shotForward, new Vector3(1, 0, 1));
                shotForward = shotForward.normalized;
                //力を加える
                rigidbody.AddForce(shotForward * strikerSpeed);
                Debug.Log(shotForward);
                GameManager.playerTurn = true;
                GreenGameManager.GreenplayerTurn = false;
                Invoke("StartPosition", 3);

         }
      }
    } 
    
    void StartPosition()
    {
        transform.position = startPosition;
    }
}
