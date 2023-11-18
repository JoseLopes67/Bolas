using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ScoreText : MonoBehaviour
{
    public TMP_Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.SetText("Score :" + Score.instance.GetScore());
    }
}
