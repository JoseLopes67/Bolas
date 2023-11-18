using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;


    



    public TMP_Text score;

    public TMP_Text highscore;

    int scoreIndex = 0;

    int highIndex = 0;

    void Start()        
    {
        score.SetText("Score :" + scoreIndex);

        highscore.SetText("HighScore :" + highIndex);

        DontDestroyOnLoad(gameObject);
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad (gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    



    void Update()
    {

    }

    public void AddScore()
    {
        scoreIndex++;

        HighScore();
    }


    public int GetScore()
    {
        return scoreIndex;
    }

    

    void HighScore()
    {
        if (scoreIndex > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", scoreIndex);
        }

        highscore.text = "HighScore: " + PlayerPrefs.GetInt("HighScore");

       

    }
}
