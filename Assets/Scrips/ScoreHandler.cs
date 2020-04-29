using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class ScoreHandler : MonoBehaviour
{
    // Start is called before the first frame update

    public Text ScoreText;
    public Image ScoreIcon;
    int score = 0;
    int highScore = 0;

    public void Start()
    {
        GetLastHighScore();
    }

    public void UpdateScore()
    {
        score++;
        ScoreText.text = score.ToString();
        ScoreIcon.color = Color.black;

        if (score > highScore)
            SaveScore(score);

    }

    public void ColorIcon()
    {
        ScoreIcon.color = Color.red;
    }

    public void GetLastHighScore()
    {
        highScore = PlayerPrefs.GetInt("HighScore");

    }

    public void SaveScore(int _score)
    {
        ScoreIcon.color = Color.green;
        PlayerPrefs.SetInt("HighScore", _score);
    }


}