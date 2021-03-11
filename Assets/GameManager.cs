using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Sphere;
    Rigidbody rigidbody;
    private Vector3 startPosition;
   
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetMouseButtonDown (0)) {

         Invoke("Speed", 1);
 
		}
 
		if (Input.GetKey (KeyCode.Space)) {

            Invoke("Speed2", 1);
		}   
    }

    void Speed(){
        transform.position = startPosition;
        Sphere.SetActive (false);

    }

    void Speed2(){
        transform.position = startPosition;
        Sphere.SetActive (true);
 
    }
}
