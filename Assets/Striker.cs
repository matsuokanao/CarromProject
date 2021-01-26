using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Striker : MonoBehaviour
{
    Rigidbody rigidbody;
    public int strikerSpeed = 50;
   
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
  
    }

    private void Update()

    {
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
               
        }
    }
}
