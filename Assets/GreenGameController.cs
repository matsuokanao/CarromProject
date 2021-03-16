using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenGameController : MonoBehaviour
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
        objects = GameObject.FindGameObjectsWithTag("brown");
        redobjects = GameObject.FindGameObjectsWithTag("red");

        if(objects.Length == 0 && redobjects.Length == 0){

           clearUi.SetActive(true);

        }
    }
}
