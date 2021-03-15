using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    public GameObject clearUi;
    GameObject[] objects;
   
    void Start()
    {
        clearUi.SetActive(false);
    }

    void Update()
    {

        objects = GameObject.FindGameObjectsWithTag("white");

        if(objects.Length == 0){

           clearUi.SetActive(true);

        }
    }
}
