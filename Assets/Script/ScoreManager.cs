using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    public Text highscoreText;
    public AudioClip Point;
    public AudioSource audio3;

    public int score = 0;
    int highscore = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "SCORE : " + score.ToString();
        highscoreText.text = "HIGHSCORE : " + highscore.ToString();
    }

    // Update is called once per frame
    public void AddPoint()
    {
        score += 1;
        scoreText.text = "Score :" + score.ToString();
        if (highscore < score)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
        audio3 = GetComponent<AudioSource>();
        audio3.clip = Point;
        audio3.Play();
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("highscore");
    }


}
