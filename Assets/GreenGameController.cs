using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenGameController : MonoBehaviour
{

    public GameObject clearUi;
    GameObject[] objects;

    // Start is called before the first frame update
    void Start()
    {
        clearUi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        objects = GameObject.FindGameObjectsWithTag("brown");

        if(objects.Length == 0){

           clearUi.SetActive(true);

        }
    }
}
