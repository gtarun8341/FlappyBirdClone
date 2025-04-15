using UnityEngine;
using TMPro;
using System;
public class Score : MonoBehaviour
{
    public static Score instance;
    [SerializeField] private TextMeshProUGUI currentScore;
    [SerializeField] private TextMeshProUGUI highScore;
    private int score;

    void Awake()
    {
        if(instance == null){
            instance = this;
        }

    }
    void Start()
    {
        currentScore.text = score.ToString();
        highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
        updateHighScore();
    }

    private void updateHighScore()
    {
        if(score > PlayerPrefs.GetInt("HighScore", 0)){
            PlayerPrefs.SetInt("HighScore",score);
            highScore.text = score.ToString();
        }
    }
    public void updateScore(){
        score++;
        currentScore.text = score.ToString();
        updateHighScore();
    }


}
