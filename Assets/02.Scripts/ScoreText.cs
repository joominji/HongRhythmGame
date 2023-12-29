using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public static ScoreText instance;
    private TMP_Text _scoreText;
    public int score
    {
        get
        {
            return GameStatus.score;
        }
    }
    private int _score;
    
    private void Awake()
    {
        instance = this;
        _scoreText = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        _scoreText.text = score.ToString();
    }


}
