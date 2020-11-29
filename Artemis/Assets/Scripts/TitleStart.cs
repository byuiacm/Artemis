using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleStart : MonoBehaviour
{
  

    public void GameStart(){
        SceneManager.LoadScene("SampleScene");
    }

    public void Update()
    {
        if (Input.GetKeyDown("space") || (Input.GetKeyDown("return")))
        {
            GameStart();
        }
    }
 
}
