using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Sphere;
    public static bool playerTurn;
   
    // Start is called before the first frame update
    void Start()
    {
        Sphere.SetActive (true);
        playerTurn = true;
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetMouseButtonDown (0)) {

     if (playerTurn == true) {
         
         
         Invoke("Speed", 2);
 
		}
 
		if (playerTurn == false) {

            Invoke("Speed2", 2);
        }
	}   
 }

    void Speed(){

        Sphere.SetActive (false);
        //playerTurn = false;

    }

    void Speed2(){

        Sphere.SetActive (true);
        //playerTurn = true;
 
    }
}
