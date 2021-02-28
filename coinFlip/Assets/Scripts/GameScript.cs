using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    public Button TailButton;
    public Button HeadButton;
    public Text ScoreText;

    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = score.ToString();
        TailButton.onClick.AddListener(TailButtonOnClick);
        HeadButton.onClick.AddListener(HeadButtonOnClick);
    }

    void HeadButtonOnClick()
    {
        int randomValue = UnityEngine.Random.Range(0, 2);
        if (randomValue == 1)
            score += 100;
        else score -= 100;
        ScoreText.text = score.ToString();
        GameHistory.games.Add(new Game { id = GameHistory.games.Count, guessed = 1, actual = randomValue });

    }

    void TailButtonOnClick()
    {
        int randomValue = UnityEngine.Random.Range(0, 2);
        if (randomValue == 0)
            score += 100;
        else
            score -= 100;
        ScoreText.text = score.ToString();
        GameHistory.games.Add(new Game { id = GameHistory.games.Count, guessed = 0, actual = randomValue });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
