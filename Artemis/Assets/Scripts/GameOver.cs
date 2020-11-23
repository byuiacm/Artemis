using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void ReturnToTitle()
    {
        // SceneManager.LoadScene("Title"); or replace with whatever the title scene is called
        Debug.Log("Return to Title");
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        // Application.Quit is ignored in the editor
        Application.Quit();
    }
}
