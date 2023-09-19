using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
        ScoreManager.instance.Reset();
        Debug.Log("Game Quit");
    }

    public void Play()
    {
        SceneManager.LoadScene("Space");
        Time.timeScale = 1f;
    }
}
