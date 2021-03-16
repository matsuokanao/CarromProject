using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    public GameObject clearUi;
    GameObject[] objects;
    GameObject[] redobjects;
   
    void Start()
    {
        clearUi.SetActive(false);
    }

    void Update()
    {

        objects = GameObject.FindGameObjectsWithTag("white");
        redobjects = GameObject.FindGameObjectsWithTag("red");

        if(objects.Length == 0 && redobjects.Length == 0){

           clearUi.SetActive(true);

        }
    }
}
