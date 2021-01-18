using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Striker : MonoBehaviour
{
    Rigidbody rigidbody;
    public int strikerSpeed = 500;


    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
  
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))

        {

            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 shotForward = Vector3.Scale((mouseWorldPos - transform.position), new Vector3(1, 0, 1)).normalized;
            rigidbody.AddForce(shotForward * strikerSpeed);

        }
    }
}
