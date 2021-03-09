using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenStriker : MonoBehaviour
{
    Rigidbody rigidbody;
    public int strikerSpeed = 50;
    public GameObject clearUi;

    void Start () {

        clearUi.SetActive(false);

    }

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
  
    }

    private void Update()

    {
        if(Striker.playerTurn == false){

       //マウスボタンを押したらÏ
       if (Input.GetMouseButtonDown(0))

          {
                //カメラの位置を取得
                Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                //向きの生成（上方向の除去）
                Vector3 shotForward = mouseWorldPos - transform.position;
                shotForward = Vector3.Scale(shotForward, new Vector3(1, 0, 1));
                shotForward = shotForward.normalized;
                //力を加える
                rigidbody.AddForce(shotForward * strikerSpeed);
                Debug.Log(shotForward);
                Striker.playerTurn = true;
                clearUi.SetActive(true);
          }
        }
    }
}
