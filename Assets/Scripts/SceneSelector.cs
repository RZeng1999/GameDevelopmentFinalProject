using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelector : MonoBehaviour
{
    public void toPolicyTree()
    {
        SceneManager.LoadScene(2);
    }

    public void toMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void toMainGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
