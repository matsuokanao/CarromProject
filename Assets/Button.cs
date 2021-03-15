using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    public GameObject clearUi;
    GameObject[] objects;
    GameObject[] brownobjects;

    // Start is called before the first frame update
    void Start()
    {
        clearUi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        objects = GameObject.FindGameObjectsWithTag("white");
        brownobjects = GameObject.FindGameObjectsWithTag("brown");

        if(objects.Length == 0 || brownobjects.Length == 0){

           clearUi.SetActive(true);

        }
    }

     public void ReloadGame() {
          // 現在のシーン名を取得してシーンを読み込む
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // シーンを読み込んだら score(10 点以上が入っている)を 0 に戻す
        Score.score = 0;
        GreenScore.Greenscore = 0;
    }
}
