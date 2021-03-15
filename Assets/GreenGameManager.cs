using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenGameManager : MonoBehaviour
{
    public GameObject Sphere;
    public static bool GreenplayerTurn;

    // Start is called before the first frame update
    void Start()
    {
        Sphere.SetActive (false);
        GreenplayerTurn = false;

    }

    // Update is called once per frame
    void Update()
   {
     if (Input.GetMouseButtonDown (0)) {

     if (GreenplayerTurn == false) {
         
         Invoke("Speed", 2);
 
		}

        if (GreenplayerTurn == true) {

            Invoke("Speed2", 2);
        }
	}   
 }
    void Speed(){

        Sphere.SetActive (true);
        GreenplayerTurn = true;
    }

    void Speed2(){

        Sphere.SetActive (false);
        GreenplayerTurn = false;

    }
}
