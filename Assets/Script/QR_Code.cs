using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QR_Code : MonoBehaviour
{
    [SerializeField]
    GameObject QR;

    public void Pausee()
    {
        QR.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Resume()
    {
        QR.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Retry()
    {
        SceneManager.LoadScene("Space");
        Time.timeScale = 1f;
    }
    public void Title()
    {
        SceneManager.LoadScene("Menu");
    }
}
